using System;
using RestSharp;

namespace NetSeleniumDemo.APITests
{
	public class BaseApi
	{
		public static string Authorization;

		public static string token = System.Environment.GetEnvironmentVariable("Token");
		
		protected static RestClient client = new RestClient("https://api.spotify.com/");

		public BaseApi()
		{

        }

		public void Request()
		{

			RestRequest request = new RestRequest();


		}

		public static void GetAuthToken()
		{
            RestRequest request = new RestRequest();
			
			RestResponse response = client.Get<RestResponse>(request);

			//response.Content;
        }
	}
}

