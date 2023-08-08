using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.WorkLocationDto
{
	public class ListWorkLocationDto
	{
        [JsonPropertyName("workLocationId")]
        public Guid WorkLocationId { get; set; }
        [JsonPropertyName("workLocationName")]
        public string? Name { get; set; }
    }
}

