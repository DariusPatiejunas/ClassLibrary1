// 2021-11-17, Darius Patiejunas,PVMsk
using ClassLibrary4.NewFolder1Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.NewFolder2Test
{
    public class PVMskaiciuokleTest : BaseTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tax.lt/skaiciuokles/pvm_skaiciuokle");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.ClassName("fc-button-label")).Click();
            driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }
        [Test]

        public void TestPVMskaiciuoklePage()
        {
            PVMskaiciuoklePage _page = new PVMskaiciuoklePage(driver);

            string skaicius = "5";
            _page.PvmTarifas5(skaicius);            
            string amount_wo_vat = "500";            
            _page.SumabePVM("500");



        }
    }
}
