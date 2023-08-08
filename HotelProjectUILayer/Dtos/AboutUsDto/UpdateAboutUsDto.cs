using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.AboutUsDto
{
	public class UpdateAboutUsDto
	{
        [JsonPropertyName("id")]
        public Guid id { get; set; }
        [JsonPropertyName("title1")]
        public string? title1 { get; set; }
        [JsonPropertyName("title2")]
        public string? title2 { get; set; }
       
    }
}

