using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.RoomDto
{
	public class UpdateRoomDto
	{
        [JsonPropertyName("id")]
        public Guid id { get; set; }
        [JsonPropertyName("roomNumber")]
        public string? roomNumber { get; set; }
        [JsonPropertyName("coverImage")]
        public string? coverImage { get; set; }
        [JsonPropertyName("price")]
        public float price { get; set; }
        [JsonPropertyName("title")]
        public string? title { get; set; }
        [JsonPropertyName("bedCount")]
        public string? bedCount { get; set; } //Yatak Sayısı
        [JsonPropertyName("bathCount")]
        public string? bathCount { get; set; } //Banyo Sayısı
        [JsonPropertyName("wifi")]
        public string? wifi { get; set; }
        [JsonPropertyName("description")]
        public string? description { get; set; }
    }
}

