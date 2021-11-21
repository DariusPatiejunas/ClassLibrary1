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
        public static RegistracijaDemoPage _page;
        public object page;
        public object _emailInput;
        public object user;
        private string user_password;

        [OneTimeSetUp]
        public void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new RegistracijaDemoPage(driver);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _page.CloseBrowser();
        }

        [Test]
        public void TestUserInput(string user_login)
        {
            _page.UserInput(user_login);

        }
        [Test]
        public void TestEmailInput(string email_Input)
        {
            _page.EmailInput(email_Input);

        }
        [Test]
        public void PasswordInput(string password_Input)
        {
            _page.PasswordInput(password_Input);

        }
    }
}
