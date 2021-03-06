using ClassLibrary4.NewFolder1Page;
using ClassLibrary4.NewFolderPage1;
using ClassLibrary4.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4.Tools

{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static RegistracijaPage _RegistracijaPage;

        public static object CustomDriver { get; private set; }

        [OneTimeSetUp]

        public static void SetUp() =>
            // driver = CustomDriver.GetChromeDriver();
            _RegistracijaPage = new RegistracijaPage(driver);
        [TearDown]

        public static void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreenshot(driver);

        }
        [OneTimeTearDown] 

        public static void TearDown()
        {
            driver.Quit();
        }

    }
}
