using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary4.NewFolder1Page
{
    public class RegistracijaPage
    {
        private static IWebDriver _driver;

        private IWebElement _userInput => _driver.FindElement(By.Id("user_login"));        
        private IWebElement _emailInput => _driver.FindElement(By.Id("user_email"));        
        private IWebElement _passwordInput => _driver.FindElement(By.Id("user_password"));        
        private IWebElement _du_plius_duInput => _driver.FindElement(By.Id("du_plius_du"));                  
        private IWebElement _button => _driver.FindElement(By.Name("button"));
        private IWebElement _result =>_driver.FindElement(By.Id("flash_message"));

        public RegistracijaPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }
        public void UserInput(string text)
        {
            _userInput.SendKeys(text);
        }
        public void EmailInput(string text1)
        {
            _emailInput.SendKeys(text1);
        }
        public void PasswordInput(string text)
        {
            _passwordInput.SendKeys(text);
        }
        public void DuPliusDuInput(string text)
        {
            _du_plius_duInput.SendKeys(text);
        }                                
        public void ClickButton()
        {
            _button.Click();
        }
        public void Result(string expectedResult)
        {
           Assert.AreEqual(expectedResult, _result.Text, " Klaidingas saugos kodas ");
        }
    }
}
