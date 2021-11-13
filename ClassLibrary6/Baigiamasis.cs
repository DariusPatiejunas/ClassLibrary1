using ClassLibrary6;
using jsreport.Types;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AtsiskaitymoDarbas
{
    public class Baigiamasis
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.tax.lt/";
            chrome.Quit();
        }
    }
}
