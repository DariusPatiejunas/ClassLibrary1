using ClassLibrary6;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AtsiskaitymoDarbas
{
    public class Baigiamasis
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.tax.lt";
            chrome.Quit();
        }
        [Test]
        public static void TestTaxPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.tax.lt";
            IWebElement VartotojasInputField = chrome.FindElement(By.Id("user_login"));
            IWebElement SlaptazodisInputField = chrome.FindElement(By.Id("user_password"));
            IWebElement Checkbox = chrome.FindElement(By.Id("user_remember_me"));

            VartotojasInputField.SendKeys("Test");
            SlaptazodisInputField.SendKeys("Test");

            //chrome.Quit();
        }
    }
}
