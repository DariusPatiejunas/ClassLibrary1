// 2021-11-10, Darius Patiejunas
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
public class TS1Test
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
    public void tS1()
    {
        driver.Navigate().GoToUrl("https://www.seb.lt/privatiems/kreditai/busto-kreditas#1");
        driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
        driver.SwitchTo().Frame(0);
        driver.FindElement(By.Id("income")).Click();
        driver.FindElement(By.Id("income")).SendKeys("1000");
        driver.FindElement(By.Id("city")).Click();
        {
            var dropdown = driver.FindElement(By.Id("city"));
            dropdown.FindElement(By.XPath("//option[. = 'Klaipėda']")).Click();
        }
        driver.FindElement(By.CssSelector("#calculate > .ng-binding")).Click();
    }
}
