using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HotelProjectUILayer.Dtos.AppUserDto
{
    public class ResultAppUserDto
    {
        [JsonProperty("name")]
        public string? name { get; set; }
        [JsonProperty("surname")]
        public string? surname { get; set; }
        [JsonProperty("city")]
        public string? city { get; set; }
        [JsonProperty("country")]
        public string? country { get; set; }
        [JsonProperty("gender")]
        public string? gender { get; set; }
        [JsonProperty("workLocationId")]
        public Guid workLocationId { get; set; }
        [JsonProperty("workLocationName")]
        public string? workLocationName { get; set; }

    }
    

}

