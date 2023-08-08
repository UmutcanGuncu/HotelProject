using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.BookingDto
{
	public class ResultLast6BookingDto
	{
        [JsonPropertyName("id")]
		public Guid Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("mail")]
        public string? Mail { get; set; }
        [JsonPropertyName("checkIn")]
        public string? CheckIn { get; set; }
        [JsonPropertyName("checkOut")]
        public string? CheckOut { get; set; }
        [JsonPropertyName("adultCount")]
        public string? AdultCount { get; set; }
        [JsonPropertyName("childCount")]
        public string? ChildCount { get; set; }
        [JsonPropertyName("roomCount")]
        public string? RoomCount { get; set; }
        [JsonPropertyName("specialRequest")]
        public string? SpecialRequest { get; set; }
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("city")]
        public string? City { get; set; }
        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }
}

