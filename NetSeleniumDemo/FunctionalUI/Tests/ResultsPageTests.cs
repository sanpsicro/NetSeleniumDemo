using System;
using NetSeleniumDemo.Pages;

namespace NetSeleniumDemo.Tests
{
	public class ResultsPageTests : BaseTest
	{

		ResultsFile rFiles = new ResultsFile();
		Login Login = new Login();

		[Test]
		public void ResultsTests()
		{
			Login.GotoLoginPage();
		

            rFiles.ValidateResultsInREsultsFile();


        }
	}
}

