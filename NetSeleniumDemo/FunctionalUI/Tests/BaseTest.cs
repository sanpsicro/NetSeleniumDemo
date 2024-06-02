using System;
using NetSeleniumDemo.Pages;
using OpenQA.Selenium;

namespace NetSeleniumDemo.Tests
{
	public class BaseTest : BasePage
	{
        public BaseTest()
		{
		}

        [SetUp]
        public void setUp()
        {
            Browser = Driver.WebBrowser.GetDriver(Driver.BrowserType.CHROME);
            Browser.Manage().Window.Maximize();
        }

        [TearDown]
        public void tearDown()
        {

            Browser.Close();
            Browser.Quit();
        }
    }
}

