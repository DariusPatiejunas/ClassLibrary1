// 2021-11-08, Darius Patiejunas, vartutechnika
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    class Vartutechnika
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "http://vartutechnika.lt/";
           // _driver.Navigate().GoToUrl("http://vartutechnika.lt/");
            WebDriverWait wait = new WebDriverWait(_driver,
                                                   TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.Id("cokiescript_reject")).Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //  _driver.Quit();
        }

        [TestCase("2000", "2000", true, false, "665.98", TestName = "2000x2000+vartu automatika = 665.98")]
        public static void TestVartuTechnikaPage(string aukstis, string plotis, bool automatika, bool montavimoDarbai, string result)
        {
            IWebElement plotisInput = _driver.FindElement(By.Id("doors_plotis"));
            plotisInput.Clear();
            plotisInput.SendKeys(plotis);
            IWebElement aukstisInput = _driver.FindElement(By.Id("doors_aukstis"));
            aukstisInput.Clear();
            aukstisInput.SendKeys(aukstis);
            IWebElement montavimoCheckbox = _driver.FindElement(By.Id("automatika"));
            {
                if (automatika != montavimoCheckbox.Selected)
                    montavimoCheckbox.Click();
            }
            IWebElement montavimoCheckBox = _driver.FindElement(By.Id("darbai"));
            {
                if (montavimoDarbai != montavimoCheckbox.Selected)
                    montavimoCheckbox.Click();
            }

        }
    }
}
