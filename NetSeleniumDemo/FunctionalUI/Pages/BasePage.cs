using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NetSeleniumDemo.Pages
{
	public class BasePage : IPage
	{

        public static IWebDriver Browser;

        public BasePage()
		{
		}


		public static WebDriverWait Wait(int seconds = 60)
		{
			WebDriverWait wait = new WebDriverWait(Browser,TimeSpan.FromSeconds(seconds));

			return wait;
		}
		
	}
}

