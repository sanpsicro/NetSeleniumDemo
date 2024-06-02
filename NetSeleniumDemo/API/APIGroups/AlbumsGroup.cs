using System;
using RestSharp;

namespace NetSeleniumDemo.APITests
{
	public class AlbumsGroup : BaseApi
	{
		public AlbumsGroup()
		{
		}

		public void GetAlbumGroupByName(string albumName)
		{
			RestRequest request = new RestRequest("v1/albums");
			
			RestResponse response = client.Get<RestResponse>(request);
}
	}
}

