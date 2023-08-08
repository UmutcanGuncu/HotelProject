using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.TestimonialDto
{
	public class ResultTestimonialDto
	{
        [JsonPropertyName("name")]
        public string? name { get; set; }
        [JsonPropertyName("title")]
        public string? title { get; set; }
        [JsonPropertyName("description")]
        public string? description { get; set; }
        [JsonPropertyName("image")]
        public string? image { get; set; }
        
    }
 }


