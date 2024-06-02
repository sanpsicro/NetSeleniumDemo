using System;
using OpenQA.Selenium;

namespace NetSeleniumDemo.Pages
{
	public class Login : BasePage
	{
		public static By Googlelogo = By.XPath("//img[@alt='Google']");
        public static By InputField = By.XPath("//img[@alt='Google']");

        public Login()
		{
		}

		/// <summary>
		/// Go to login page and validates logo ins present
		/// </summary>
		public void GotoLoginPage()
		{
			Browser.Navigate().GoToUrl("https://www.google.com");

			Console.WriteLine(Browser.Url);
			Wait().Until<Boolean>((_d)=>Browser.FindElement(Googlelogo).Displayed);

			Assert.IsTrue(Browser.FindElement(Googlelogo).Displayed);

		}


		/// <summary>
		/// Do a search in the main page and wait for the results
		/// </summary>
		/// <param name="stringToSearchFor"></param>
		public void SearchForResults(string stringToSearchFor)
		{
            Wait().Until<Boolean>((_d) => Browser.FindElement(InputField).Displayed);

			Browser.FindElement(InputField).SendKeys(stringToSearchFor);

            Wait().Until<Boolean>((_d) => Browser.FindElement(InputField).Displayed);

        }
    }
}

