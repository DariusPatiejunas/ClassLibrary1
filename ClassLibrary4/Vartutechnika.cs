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
            // _driver.Url = "http://vartutechnika.lt/";
            _driver.Navigate().GoToUrl("http://vartutechnika.lt/");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.Id("cookiescript_reject")).Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }

        [TestCase("2000", "2000", true, false, "665.98", TestName = "2000 x 2000 + vartu automatika = 665.98")]
        [TestCase("4000", "2000", true, true, "1006.43", TestName = "4000 x 2000 + vartu automatika + vartu montavimo darbai = 1006.43")]
        [TestCase("4000", "2000", false, false, "692.35", TestName = "4000 x 2000 + vartu automatika = 692,35")]
        [TestCase("5000", "2000", false, true, "989.21", TestName = "5000 x 2000 + vartu automatika = 989.21")]
        public static void TestVartuTechnikaPage(string plotis, string aukstis, bool automatika, bool montavimoDarbai, string result)
        {
            IWebElement plotisInput = _driver.FindElement(By.Id("doors_width"));
            plotisInput.Clear();
            plotisInput.SendKeys(plotis);
            IWebElement aukstisInput = _driver.FindElement(By.Id("doors_height"));
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
         
          // _driver.FindElement(By.Id("calc_submit")).Click();
          //  WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
          //  wait.Until(d => d.FindElement(By.CssSelector("#calc_result >div")).Displayed);
          //  IWebElement resultBox = _driver.FindElement(By.CssSelector("#calc_result >div"));
         //   Assert.IsTrue(resultBox.Text.Contains(result), $"Result is not the same, expected {result},but was {resultBox.Text}");


        }

    }
}