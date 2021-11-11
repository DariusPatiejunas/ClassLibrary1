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
[TestFixture]
public class Class8
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
        driver.Quit();
    }
    [Test]
    public void testas1()
    {
        driver.Navigate().GoToUrl("https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
        driver.FindElement(By.Id("id_user_agent")).Click();
        driver.FindElement(By.Id("parse-useragent")).Click();
        driver.FindElement(By.Id("id_user_agent")).SendKeys(" Chrome/95.0.4638.69 ");
        driver.FindElement(By.CssSelector(".button-filled-darkblue")).Click();
    }
}