using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HotelProjectUILayer.Dtos.WorkLocationDto
{
	public class ResultWorkLocationDto
	{
        [JsonPropertyName("workLocationId")]
        public Guid WorkLocationId { get; set; }
        [JsonPropertyName("workLocationName")]
        public string? Name { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
    }
}

