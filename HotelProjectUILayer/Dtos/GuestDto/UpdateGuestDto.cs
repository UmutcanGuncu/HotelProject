﻿
using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.GuestDto
{
	public class UpdateGuestDto
	{
        [JsonPropertyName("id")]
        public Guid id { get; set; }
        [JsonPropertyName("name")]
        public string? name { get; set; }
        [JsonPropertyName("surname")]
        public string? surname { get; set; }
        [JsonPropertyName("city")]
        public string? city { get; set; }
    }
}

