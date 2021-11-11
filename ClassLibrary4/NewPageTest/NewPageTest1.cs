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
			_driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
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
		public void tS1()
		{
            _driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
			_driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
			_driver.FindElement(By.Id("isAgeSelected")).Click();
		}
	}
}

	
