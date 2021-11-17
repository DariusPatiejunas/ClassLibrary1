// 2021-11-17, Darius Patiejunas, Objekt Page
using ClassLibrary4.NewFolderPage1;
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
        private string user_password;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.tax.lt/login");
            IWebElement button = _driver.FindElement(By.ClassName("fc-button-label"));
            button.Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }
        [Test]

        public void TestTaxPage()
        {
            TaxPage page = new TaxPage(_driver);

            string text = "Test";
            page.LoginInputField(text);
            page.passwordInputField(text);
            string check = "check";
            page.Checbox(check);

        }
    }
}


