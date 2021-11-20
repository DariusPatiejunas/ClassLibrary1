using ClassLibrary4.NewFolder1Page;
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
    public class RegistracijaTest
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
        public void TestTaxPage()
        {
            RegistracijaPage page = new RegistracijaPage(_driver);

            string text = "Vartotojas";
            page.UserInput(text);
            string text1 = "Patiejun@gmail.com";
            page.EmailInput(text1);
            string text2 = "12345";
            page.PasswordInput(text2);
            string text3 = "šešiolika";
            page.DuPliusDuInput(text3);
            string click = "button";
            page.ClickButton();
            string result = "expectedResult";
            page.Result(result);

        }
    }
}
