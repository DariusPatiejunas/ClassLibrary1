// 2021-11-05, Darius Patiejunas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using jsreport.Types;

[TestFixture]
public class HttpsdemoseleniumeasycombasicfirstformdemohtmlTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
       // driver.Quit();
    }
    [Test]
    public void httpsdemoseleniumeasycombasicfirstformdemohtml()
    {
        driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
        Thread.Sleep(5000);
        IWebElement popUp = driver.FindElement(By.Id("at-cv-lightbox-close"));
        popUp.Click();
        driver.FindElement(By.Id("sum1")).Click();
        driver.FindElement(By.Id("sum1")).SendKeys("4");
        driver.FindElement(By.Id("sum2")).Click();
        driver.FindElement(By.Id("sum2")).SendKeys("5");
        driver.FindElement(By.CssSelector(".btn:nth-child(3)")).Click();
        
    }
}
