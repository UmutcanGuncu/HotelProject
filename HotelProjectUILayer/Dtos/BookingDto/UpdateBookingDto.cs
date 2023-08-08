using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.BookingDto
{
	public class UpdateBookingDto
	{
        [JsonPropertyName("id")]
        public Guid id { get; set; }
        [JsonPropertyName("name")]
        public string? name { get; set; }
        [JsonPropertyName("mail")]
        public string? mail { get; set; }
        [JsonPropertyName("checkIn")]
        public string? checkIn { get; set; }
        [JsonPropertyName("checkOut")]
        public string? checkOut { get; set; }
        [JsonPropertyName("adultCount")]
        public string? adultCount { get; set; }
        [JsonPropertyName("childCount")]
        public string? childCount { get; set; }
        [JsonPropertyName("roomCount")]
        public string? roomCount { get; set; }
        [JsonPropertyName("description")]
        public string? description { get; set; }
        [JsonPropertyName("specialRequest")]
        public string? SpecialRequest { get; set; }
        [JsonPropertyName("status")]
        public string? status { get; set; }
    }
}

