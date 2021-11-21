using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ClassLibrary4.NewFolder1Page
{
     public class RegistracijaDemoPage : BasePage
     {
        public string email;
        public string password;

        private IWebElement _userInput => Driver.FindElement(By.Id("user_login"));
        private IWebElement _emailInput => Driver.FindElement(By.Id("user_email"));
        private IWebElement _passwordInput => Driver.FindElement(By.Id("user_password"));
        private IWebElement _du_plius_duInput => Driver.FindElement(By.Id("du_plius_du"));
        private IWebElement _button => Driver.FindElement(By.Name("button"));
        private IWebElement _result => Driver.FindElement(By.Id("flash_message"));

        public string user{ get; private set; }

        public RegistracijaDemoPage(IWebDriver webDriver) : base(webDriver)
        {
            Driver.Url = "https://www.tax.lt/signup";
            Driver.FindElement(By.ClassName("fc-button-label")).Click();
            
        }      
        public RegistracijaDemoPage UserInput(string user_login)
        {
           _userInput.Clear();
           _userInput.SendKeys(user_login);
            return this;

        }              

        public RegistracijaDemoPage EmailInput(string user_email)
        {
            _emailInput.Clear();
            _emailInput.SendKeys(user_email);
            return this;
        }
        public RegistracijaDemoPage PasswordInput(string user_password)
        {
            _passwordInput.Clear();
            _passwordInput.SendKeys(user_password);
            return this;
        }
    }
}
