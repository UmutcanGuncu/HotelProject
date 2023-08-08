using System;
namespace HotelProjectUILayer.Dtos.FolowersDto
{
	public class ResulttLinkedinFollowersDto
	{
		public Data data { get; set; }

		public class Data
		{
			public int followers_count { get; set; }
		}
	}
}

