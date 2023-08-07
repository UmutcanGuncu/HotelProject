using System;
using Newtonsoft.Json;

namespace HotelProjectWebApi.Models
{
	public class AppUserWorkLocationViewModel
	{
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("surname")]
        public string? Surname { get; set; }
        [JsonProperty("city")]
        public string? City { get; set; }
        [JsonProperty("country")]
        public string? Country { get; set; }
        [JsonProperty("gender")]
        public string? Gender { get; set; }
        [JsonProperty("workLocationId")]
        public Guid WorkLocationId { get; set; }
        [JsonProperty("workLocationName")]
        public string? WorkLocationName { get; set; }
        
    }
}

