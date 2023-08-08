using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.ServiceDto
{
	public class ResultServiceDto
	{
        [JsonPropertyName("id")]
        public Guid id { get; set; }
        [JsonPropertyName("title")]
        public string? title { get; set; }
        [JsonPropertyName("decription")]
        public string? decription { get; set; }
        [JsonPropertyName("icon")]
        public string? icon { get; set; }
    }
}

