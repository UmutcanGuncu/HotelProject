using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.AppUserDto
{
    public class ResultAppUserDto
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("surname")]
        public string? Surname { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }
        [JsonPropertyName("workLocationId")]
        public Guid WorkLocationId { get; set; }


    }
    public  class workLocationId
    {
        [JsonPropertyName("workLocationId")]
        public Guid WorkLocationId { get; set; }

        
    }

}

