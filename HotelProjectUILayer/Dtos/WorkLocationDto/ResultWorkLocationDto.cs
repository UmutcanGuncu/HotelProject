using System;
using Newtonsoft.Json;

namespace HotelProjectUILayer.Dtos.WorkLocationDto
{
	public class ResultWorkLocationDto
	{
        [JsonProperty("WorkLocationId")]
        public Guid workLocationId { get; set; }
        [JsonProperty("WorkLocationName")]
        public string? name { get; set; }
        [JsonProperty("city")]
        public string? city { get; set; }
    }
}

