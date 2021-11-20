// 2021-11-15, darius Patiejunas
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.BaigiamasisDarbas
{
    class PVMskaiciuokle
    {
        public static IWebDriver _driver;       

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.tax.lt/skaiciuokles/pvm_skaiciuokle");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.ClassName("fc-button-label")).Click();
            _driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]
        public static void Testpvm_skaiciuokle()
        {
            
           // IWebElement PvmTarifas21 = _driver.FindElement(By.Id("vat_percent"));
           // IWebElement PvmTarifas9 = _driver.FindElement(By.Id("vat_percent"));
            IWebElement PvmTarifas5 = _driver.FindElement(By.Id("vat_percent"));            
           // _driver.FindElement(By.XPath("//option[. = '21%']")).Click();
           // _driver.FindElement(By.XPath("//option[. = '9%']")).Click();
            _driver.FindElement(By.XPath("//option[. = '5%']")).Click();
            IWebElement sumabePVM = _driver.FindElement(By.Id("amount_wo_vat"));
            _driver.FindElement(By.Id("amount_wo_vat")).Clear();
            sumabePVM.SendKeys("500");
            IWebElement PVMsuma = _driver.FindElement(By.Id("vat_amount"));
            IWebElement bendrasuma = _driver.FindElement(By.Id("total_amount"));




        }

    }
}

