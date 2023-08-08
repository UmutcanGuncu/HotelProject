using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.StaffDto
{
	public class ResultLast4StaffDto
	{
        [JsonPropertyName("id")]
		public Guid Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }
        
    
	}
}

