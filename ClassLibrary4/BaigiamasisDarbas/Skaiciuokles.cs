// 2021-11-14, Darius Patiejunas , Skaiciuokles
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClassLibrary4.BaigiamasisDarbas
{
    class Skaiciuokles
    {

        public static IWebDriver _driver;
        

       

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://www.tax.lt/skaiciuokles/atlyginimo_ir_mokesciu_skaiciuokle");
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
           // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(By.ClassName("fc-button-label")).Click();
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }
        [Test]
        public static void Testskaiciuokle()
        {
           IWebElement metai = _driver.FindElement(By.Id("mokestiniai_metai"));
           _driver.FindElement(By.XPath("//option[. = '2019']")).Click();
           IWebElement koks_atl = _driver.FindElement(By.Id("koks_atl_2"));
           koks_atl.Click();
           IWebElement checkbox = _driver.FindElement(By.Id("papildomas_pensijos_kaupimas"));
           checkbox.Click();
           IWebElement atlyginimas = _driver.FindElement(By.Id("atlyginimas"));
           atlyginimas.Click();
           _driver.FindElement(By.Id("atlyginimas")).SendKeys("1000");
           IWebElement procentai = _driver.FindElement(By.Id("papildomas_pensijos_kaupimas_procentai"));
           // procentai.Click();
           //_driver.FindElement(By.XPath("//option[. = '3 %']")).Click();
           _driver.FindElement(By.XPath("//option[. = '1.8 %']")).Click();

        }
        [Test]
        public static void Testantpopieriaus()
        {
            IWebElement metai = _driver.FindElement(By.Id("mokestiniai_metai"));
            _driver.FindElement(By.XPath("//option[. = '2020']")).Click();
            IWebElement koks_atl = _driver.FindElement(By.Id("koks_atl_1"));
            koks_atl.Click();
            _driver.FindElement(By.Id("atlyginimas")).SendKeys("1000");          
            IWebElement paskaiciuoti_npd = _driver.FindElement(By.Id("paskaiciuoti_npd_2"));
            paskaiciuoti_npd.Click();
            IWebElement paskaiciuotinpd = _driver.FindElement(By.Id("papildomas_pensijos_kaupimas"));
            paskaiciuotinpd.Click();
            _driver.FindElement(By.Id("taikomas_npd")).Clear();
            _driver.FindElement(By.Id("taikomas_npd")).SendKeys("100");
            IWebElement atlyginimas = _driver.FindElement(By.Id("atlyginimas"));            
            IWebElement procentai = _driver.FindElement(By.Id("papildomas_pensijos_kaupimas_procentai"));
            // procentai.Click();
            //_driver.FindElement(By.XPath("//option[. = '3 %']")).Click();
            _driver.FindElement(By.XPath("//option[. = '2.1 %']")).Click();

        }

        



    }
}