using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.AboutUsDto
{
	public class ResultAboutUsDto
	{
        [JsonPropertyName("id")]
        public Guid id { get; set; }
        [JsonPropertyName("title1")]
        public string? title1 { get; set; }
        [JsonPropertyName("title2")]
        public string? title2 { get; set; }
        [JsonPropertyName("content")]
        public string? content { get; set; }
        [JsonPropertyName("roomCount")]
        public int roomCount { get; set; }
        [JsonPropertyName("staffCount")]
        public int staffCount { get; set; }
        [JsonPropertyName("customerCount")]
        public int customerCount { get; set; }
    }
}

