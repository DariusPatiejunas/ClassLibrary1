// 2021-11-07, Darius Patiejunas, Ndnr2.
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    class Class3
    {

        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]

        public void Testnr()
        {
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            _driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
            _driver.FindElement(By.CssSelector(".checkbox:nth-child(3) .cb1-element")).Click();
            _driver.FindElement(By.CssSelector(".checkbox:nth-child(4) .cb1-element")).Click();
            _driver.FindElement(By.CssSelector(".checkbox:nth-child(5) .cb1-element")).Click();
            _driver.FindElement(By.CssSelector(".checkbox:nth-child(6) .cb1-element")).Click();
        }

        [Test]
        public void Testnr1()
        {
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            _driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
            _driver.FindElement(By.Id("check1")).Click();
            _driver.FindElement(By.Id("check1")).Click();
            //_driver.Quit();
        }

        [Test]
        public void Testnr3()
        {
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            _driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
            _driver.FindElement(By.Id("isAgeSelected")).Click();
            _driver.FindElement(By.Id("txtAge")).Click();
        }
    }
} 