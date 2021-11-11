using System;

public class Class1
{
	public class SeleniuminputTest
	{
		private static IWebDriver _driver;
		[OneTimeSetUp]
		public static void SetUp() 
		{
			_driver = new ChromeDriver();
			_driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
			 WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10);
			 IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
			 wait.Until(d = > popUp.Displayed);
			 popUp.Click();
		}
		[OneTimeTearDown]
		public static void TearDown()
		{
			// _driver.Quit();
		}
		[Test]

		public void TestSeleniumIputFirsBlock() 
		{
			SeleniumInputPage page = new SeleniumInputPage(_driver);
			string myText = "Labas";

			page.InsertText(myText);
			page.ClickShowMessageButton();
			page.CheckResult(myText);
		}
	}
}
