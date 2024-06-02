using System;
using NetSeleniumDemo.Pages;

namespace NetSeleniumDemo.Tests
{
	public class LoginTests : BaseTest
	{

		Login Login = new Login();

		[Test]
		public void LoginTest()
		{

			Login.GotoLoginPage();

		}
	}
}

