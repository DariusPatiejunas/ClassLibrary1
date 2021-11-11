// 2021-11-11, Darius Patiejunas ND3
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.NewPageTest
{
    public class NewPageTest1 

	
	{
		private static IWebDriver _driver;
        private object driver;

        [OneTimeSetUp]
		public static void SetUp()
		{
			_driver = new ChromeDriver();
			_driver.Url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
			WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
			IWebElement popUp = _driver.FindElement(By.Id("isAgeSelected"));
			wait.Until(d => popUp.Displayed);
			popUp.Click();
		}
		[OneTimeTearDown]
		public static void TearDown()
		{
			// _driver.Quit();
		}
		[Test]
		public void  Checkbox()
		{
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
			_driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
			_driver.FindElement(By.Id("isAgeSelected")).Click();
		}
		[Test]
		public void TestMultipleCheckbox()
        {
			_driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
			_driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
			_driver.FindElement(By.CssSelector(".checkbox:nth-child(3) .cb1-element")).Click();
			_driver.FindElement(By.CssSelector(".checkbox:nth-child(4) .cb1-element")).Click();
			_driver.FindElement(By.CssSelector(".checkbox:nth-child(5) .cb1-element")).Click();
			_driver.FindElement(By.CssSelector(".checkbox:nth-child(6) .cb1-element")).Click();
		}
		[Test]
		public void TestUncheckAll()
		{
			_driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
			_driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
			_driver.FindElement(By.Id("check1")).Click();
			_driver.FindElement(By.Id("check1")).Click();
			_driver.FindElement(By.Id("check1")).Click();
			_driver.FindElement(By.Id("check1")).Click();
		}
	}
}


	
