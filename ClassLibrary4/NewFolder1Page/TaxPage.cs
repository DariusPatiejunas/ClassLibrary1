// 2021-11-17, Darius Patiejunas, Object Page
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.NewFolderPage1
{
    public class TaxPage
    {
        private static IWebDriver _driver;
        private object _logininputField;

        private IWebElement _loginInputField => _driver.FindElement(By.Id("user_login"));
        private IWebElement _passwordInputField => _driver.FindElement(By.Id("user_password"));
        private IWebElement _Checkbox => _driver.FindElement(By.Id("user_remember_me"));

        public TaxPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }
        public void LoginInputField(string text)
        {
            _loginInputField.SendKeys(text);
        }
        public void passwordInputField(string user_password )
        {
           _passwordInputField.SendKeys(user_password);
        }

        
         public void Checbox(string uncheck)
         {
          _Checkbox.SendKeys(uncheck);
         }

    }
}