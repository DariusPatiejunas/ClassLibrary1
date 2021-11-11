﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassLibrary4.NewPageND
{
    public class Page1
    {
        private static IWebDriver _driver;
        private double expectedResultSum;

        private IWebDriver _webdriver;
        private object _FirstInput;
        private object __driver;
        public class Test2Test
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
            private IWebElement _inputField => _driver.FindElement(By.Id("isAgeSelected"));
            private IWebElement Button => _driver.FindElement(By.CssSelector("txtAge"));
            private IWebElement _result => _driver.FindElement(By.Id("display"));
            private IWebElement _button => _driver.FindElement(By.CssSelector(".checkbox:nth-child(3) .cb1-element"));
            private IWebElement _button1 => _driver.FindElement(By.CssSelector(".checkbox:nth-child(4) .cb1-element"));
            private IWebElement _button2 => _driver.FindElement(By.CssSelector(".checkbox:nth-child(5) .cb1-element"));
            private IWebElement _button3 => _driver.FindElement(By.CssSelector(".checkbox:nth-child(6) .cb1-element"));
        }
    }
}