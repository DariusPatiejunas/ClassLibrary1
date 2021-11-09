// 2021-11-06, Darius Patiejunas, Namu darbas nr.1
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    class Class4
    {
        [Test]
        public static void TestSuma()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();
            int skaicius = 2;
            IWebElement pirmasInput = chrome.FindElement(By.Id("sum1"));
            IWebElement antrasInput = chrome.FindElement(By.Id("sum2"));
            pirmasInput.SendKeys(skaicius.ToString());
            antrasInput.SendKeys(skaicius.ToString());
            int sum = skaicius + skaicius;
            chrome.FindElement(By.CssSelector("#gettotal > button")).Click();
            IWebElement atsakymas = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(sum.ToString(), atsakymas.Text, " result is 4 ");

            //chrome.Quit();
        }
        [Test]
        public static void TestSuma2()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();
            int skaicius = -5;
            int skaicius2 = 3;
            IWebElement pirmasInput = chrome.FindElement(By.Id("sum1"));
            IWebElement antrasInput = chrome.FindElement(By.Id("sum2"));
            pirmasInput.SendKeys(skaicius.ToString());
            antrasInput.SendKeys(skaicius2.ToString());
            int sum = skaicius + skaicius2;
            chrome.FindElement(By.CssSelector("#gettotal > button")).Click();
            IWebElement atsakymas = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(sum.ToString(), atsakymas.Text, " result is  ");

            // chrome.Quit();

        }

        [Test]
        public static void TestSuma3()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close"));
            popUp.Click();
            string a = "a";
            string b = "b";
            IWebElement pirmasInput = chrome.FindElement(By.Id("sum1"));
            IWebElement antrasInput = chrome.FindElement(By.Id("sum2"));
            pirmasInput.SendKeys(a.ToString());
            antrasInput.SendKeys(b.ToString());
            string sum = ("a + b");
            chrome.FindElement(By.CssSelector("#gettotal > button")).Click();
            IWebElement atsakymas = chrome.FindElement(By.Id("displayvalue"));           
            chrome.FindElement(By.CssSelector(".btn:nth-child(3)")).Click();

            //chrome.Quit();
        }







    }
}