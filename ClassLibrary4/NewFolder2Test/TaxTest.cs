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

        public void TestTaxPage()
        {
            TaxPage page = new TaxPage(_driver);

            string user_login = ("Test");
            page.InsertText(user_login);
            string user_password = ("Test");
            page.InsertPassword(user_password);
            

            // page.InsertChecbox(Text);

        }
    }
}


