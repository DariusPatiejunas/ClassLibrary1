// 2021-11-05, Darius Patiejunas
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    class Namu_darbas
    {

        private static IWebDriver _driver;
        private static object popUp;
       

        [OneTimeSetUp]
        public static void SetUp() 
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
           
        }
        [OneTimeTearDown]
        public static void TearDown() 
        {
           // _driver.Quit();
        }
       
        [TestCase("2","2","4",TestName = "2 plius 2 = 4")]
        [TestCase("-5","3","-2",TestName = "-5 plius 3 =-2")]
        [TestCase("a","b","NaN",TestName = "a plius b =NaN")]

        public static void TestSuma(string pirmasName, string antrasName, string atsakymas)
        {
            
            _driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));           
            popUp.Click();            
            IWebElement pirmasInput = _driver.FindElement(By.Id("sum1"));
            IWebElement antrasInput = _driver.FindElement(By.Id("sum2"));
            pirmasInput.Clear();
            pirmasInput.SendKeys(pirmasName);
            antrasInput.Clear();
            antrasInput.SendKeys(antrasName);
            
            _driver.FindElement(By.CssSelector("#gettotal > button")).Click();            
            IWebElement atsakymasFromPage = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(atsakymas,atsakymasFromPage.Text, " result is NOK ");

           // _driver.Quit();




        }
    }
}
