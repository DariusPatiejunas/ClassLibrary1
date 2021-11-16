using OpenQA.Selenium;

namespace ClassLibrary4.Page
{
    internal class TaxPage
    {
        private IWebDriver driver;

        public TaxPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}