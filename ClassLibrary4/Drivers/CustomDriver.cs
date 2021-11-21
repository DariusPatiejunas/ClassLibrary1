using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.Drivers
{
   public class CustomDriver
    {
        public static IWebDriver GetChromedriver()
        {
            return new ChromeDriver();
        }
        private static IWebDriver GetDriver(string browserName)
        {
            IWebDriver driver = null;

            switch (browserName)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
           // return
        }

    }
}
