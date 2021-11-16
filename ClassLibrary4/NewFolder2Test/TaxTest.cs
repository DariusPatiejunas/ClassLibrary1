using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.NewFolder2Test
{
    public class TaxTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://www.tax.lt/login");
            IWebElement button = chrome.FindElement(By.ClassName("fc-button-label"));
            button.Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }
        [Test]

        public void TestTaxtest()
        {
            Page.TaxPage page = new Page.TaxPage(_driver);

        }
    }
}


