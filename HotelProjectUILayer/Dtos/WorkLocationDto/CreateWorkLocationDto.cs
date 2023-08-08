using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.WorkLocationDto
{
	public class CreateWorkLocationDto
	{
        [JsonPropertyName("workLocationName")]
        public string? Name { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
    }
}

