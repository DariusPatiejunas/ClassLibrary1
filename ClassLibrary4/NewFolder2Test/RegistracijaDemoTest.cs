using ClassLibrary4.NewFolder1Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.NewFolder2Test
{
    public class RegistracijaDemoTest : BaseTest
    {
        private static RegistracijaDemoPage _page;
        private object page;
        private object _emailInput;

        [OneTimeSetUp]
        public  void SetUp()
        {     
            IWebDriver driver = new ChromeDriver();           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);            
            driver.Manage().Window.Maximize();
            _page = new RegistracijaDemoPage(driver);
        }

        [OneTimeTearDown]
        public  void TearDown()
        {
            _page.CloseBrowser();
        }
        
        [Test]
        public void TestUserInput()
        {
            
            _page.UserInput();
                      
        }
        [Test]
        public void TestEmailInput()
        {
            _page.EmailInput();
           
        }
        [Test]
        public void PasswordInput()
        {
            _page.PasswordInput();
        }

    }
}
