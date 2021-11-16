
using ClassVSC;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxTest
{
    public class TaxInputTest
    {
        private static IWebDriver _driver;

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
            //_driver.Quit();
        }
        [Test]
        public static void TestTaxPage()
        {
            TaxInputPage page = new TaxInputPage(_driver);
            IWebElement loginInputField = _driver.FindElement(By.Id("user_login"));
            loginInputField.SendKeys("Test");
            IWebElement passwordInputField = _driver.FindElement(By.Id("user_password"));
            passwordInputField.SendKeys("Test");
            IWebElement Checkbox = _driver.FindElement(By.Id("user_remember_me"));
        }



    }


}
