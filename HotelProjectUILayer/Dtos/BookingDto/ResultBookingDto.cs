using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.BookingDto
{
	public class ResultBookingDto
	{
        [JsonPropertyName("id")]
        public Guid id { get; set; }
        [JsonPropertyName("name")]
        public string? name { get; set; }
        [JsonPropertyName("checkIn")]
        public string? checkIn { get; set; }
        [JsonPropertyName("checkOut")]
        public string? checkOut { get; set; }
        [JsonPropertyName("status")]
        public string? status { get; set; }
    }
}

