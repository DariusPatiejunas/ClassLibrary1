        // 2021-11-07, Darius Patiejunas Ndnr2
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
    public class Nr1Test
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
           // driver.Quit();
        }
        [Test]
        public void nr1()
        {
            driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
            driver.FindElement(By.CssSelector(".checkbox:nth-child(3) .cb1-element")).Click();
            driver.FindElement(By.CssSelector(".checkbox:nth-child(4) .cb1-element")).Click();
            driver.FindElement(By.CssSelector(".checkbox:nth-child(5) .cb1-element")).Click();
            driver.FindElement(By.CssSelector(".checkbox:nth-child(6) .cb1-element")).Click();
        }
    }



