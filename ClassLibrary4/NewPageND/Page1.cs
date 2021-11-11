using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.NewPageND
{
    public class Page1
    {
        private static IWebDriver _driver;
        private double expectedResultSum;

        private IWebDriver _webdriver;
        private object _FirstInput;

        private IWebElement _inputField => _driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement _button => _driver.FindElement(By.CssSelector("txtAge"));
        private IWebElement _result => _driver.FindElement(By.Id("display"));

    }
}