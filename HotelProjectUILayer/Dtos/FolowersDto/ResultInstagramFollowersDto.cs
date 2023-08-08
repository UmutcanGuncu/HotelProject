using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.FolowersDto
{
	public class ResultInstagramFollowersDto
	{
		[JsonPropertyName("followers")]
		public int Followers { get; set; }
        [JsonPropertyName("following")]
        public int Following { get; set; }
	}
}

