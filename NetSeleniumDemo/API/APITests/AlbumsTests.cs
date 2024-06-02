using System;
using NetSeleniumDemo.APITests;

namespace NetSeleniumDemo.API.APITests
{
	public class AlbumsTests
	{
		AlbumsGroup albumsGroup = new AlbumsGroup();
		public AlbumsTests()
		{
		}

		[Test]
		public void getAlbumGroup()
		{
			albumsGroup.GetAlbumGroupByName("WonderWall");
			albumsGroup.ValidateAlbum("WonderWall",1995,11);


        }

	}
}

