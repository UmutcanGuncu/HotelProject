using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.WorkLocationDto
{
	public class UpdateWorkLocationDto
	{
        [JsonPropertyName("workLocationId")]
        public Guid WorkLocationId { get; set; }
        [JsonPropertyName("workLocationName")]
        public string? Name { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
    }
}

