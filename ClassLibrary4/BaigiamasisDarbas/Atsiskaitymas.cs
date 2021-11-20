// 2021-11-13, Darius Patiejunas, Baigiamasis darbas
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection.Emit;
using System.Windows.Controls;

namespace AtsiskaitymoDarbas
{
    public class Baigiamasis
    {
        private static object chrome;
        private static object driver;

        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.tax.lt";
            chrome.Manage().Window.Maximize();
            IWebElement button = chrome.FindElement(By.ClassName("fc-button-label"));            
            button.Click();
            IWebElement popUp = chrome.FindElement(By.Id("i6"));
            popUp.Click();
            chrome.Quit();
        }


        [Test]
        public static void TestTaxPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://www.tax.lt/login");
            IWebElement button = chrome.FindElement(By.ClassName("fc-button-label"));
            button.Click();
            chrome.Manage().Window.Size = new System.Drawing.Size(1050, 708);            
            IWebElement loginInputField = chrome.FindElement(By.Id("user_login"));
            loginInputField.SendKeys("Test");
            IWebElement passwordInputField = chrome.FindElement(By.Id("user_password"));
            passwordInputField.SendKeys("Test");
            IWebElement Checkbox = chrome.FindElement(By.Id("user_remember_me"));
           // Checkbox.Click();
           // chrome.Quit();
        }
        [Test]
        public static void TestPageLoginValidation()
       
        {
            
            IWebDriver _chrome = new ChromeDriver();
            _chrome.Navigate().GoToUrl("https://www.tax.lt/login");
            IWebElement button = _chrome.FindElement(By.ClassName("fc-button-label"));
            button.Click();
            _chrome.Manage().Window.Size = new System.Drawing.Size(1050, 708);
            IWebElement loginInputField = _chrome.FindElement(By.Id("user_login"));
            loginInputField.SendKeys("Test");
            IWebElement passwordInputField = _chrome.FindElement(By.Id("user_password"));
            passwordInputField.SendKeys("Test");
            IWebElement Checkbox = _chrome.FindElement(By.Id("user_remember_me"));
            IWebElement _button = _chrome.FindElement(By.Name("commit"));
            _button.Click();
            
        }
    
    }
}