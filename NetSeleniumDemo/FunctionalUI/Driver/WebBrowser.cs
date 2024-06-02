using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;

using WebDriverManager.DriverConfigs.Impl;

namespace NetSeleniumDemo.Driver
{
	public class WebBrowser
	{

		public static WebDriver GetDriver(BrowserType browserType)
		{
			switch (browserType)
			{
				case BrowserType.CHROME:
					new DriverManager().SetUpDriver(new ChromeConfig());
					return new ChromeDriver();
				default:
					return new ChromeDriver();

            }

        }


	}

	public enum BrowserType
	{
		CHROME,
		FIREFOX

	}
}

