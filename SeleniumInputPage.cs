using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
	public class SeleniumInputPage
	{
		private static IWebDriver _driver;
		private IWebElement _InputField => _driver.FindElement(By.Id("user-message"));
		private IWebElement _button => _driver.FindElement(By.CssSelector("#get-input>button"));
		private IWebElement _result => _driver.FindElement(By.Id("display"));

		public SeleniumInputPage (IWebDriver webDriver) 
		{
			_driver = webDriver;
		}

		public void InsertText(string text) 
		{
			_InputField.Clier();
			_InputField.Sendkeys(text);
		}
	}   
	    public void ClickShowMessageButton() 
	    {
		_button.Click();
	    }
}       public void Checkresult(string expectedresult)
        {
	       Assert.AreEqual(_expectedresult, _result.Text, "tekstas neatsidaro ");
        }

