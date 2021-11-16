// 2021-11-14, Darius Patiejunas, Baigiamasis
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.BaigiamasisDarbas
{
    class Registracija
    {

        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.tax.lt/signup");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.ClassName("fc-button-label")).Click();                  
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }
        [Test]
        public static void TestRegistracija()
        {
            IWebElement userInput = _driver.FindElement(By.Id("user_login"));
            userInput.SendKeys("Vartotojas");
            IWebElement emailInput = _driver.FindElement(By.Id("user_email"));
            emailInput.SendKeys("Patiejun@gmail.com");
            IWebElement passwordInput = _driver.FindElement(By.Id("user_password"));
            passwordInput.SendKeys("12345");
            IWebElement du_plius_duInput = _driver.FindElement(By.Id("du_plius_du"));
            du_plius_duInput.SendKeys("šešiolika");
           // IWebElement robotInput = _driver.FindElement(By.Name("g-recaptcha "));
           // IWebElement checkbox = _driver.FindElement(By.Name("recaptcha-checkbox-border"));
           //checkbox.SendKeys("check");
            IWebElement button = _driver.FindElement(By.Name("button"));
            button.Click();
           _driver.FindElement(By.Id("flash_message"));
           _driver.FindElement(By.Name("alert alert-recaptcha_error Klaidingas saugos kodas arba blogai užpildyti laukai"));




        }




    }

}  
