using ClassLibrary4.Drivers;
using ClassLibrary4.NewFolder1Page;
using Docker.DotNet.Models;
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
    public class BaseTest
    {
        public static IWebDriver driver;
        public static RegistracijaDemoPage _pageRegistracijaDemoPage;
    }
  //  [OneTimeSetUp]
    //public static void SetUp()
   // {
    //     driver = CustomDriver.GetChromeDriver();
     //    RegistracijaDemoPage _pageRegistracijaDemoPage = new RegistracijaDemoPage(driver);
    }

   // [OneTimeTearDown]

   // public static void TearDown()
   // {
    //    driver.Quit();
   // }
//}
