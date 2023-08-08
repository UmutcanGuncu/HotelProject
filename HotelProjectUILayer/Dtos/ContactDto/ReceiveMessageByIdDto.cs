using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.ContactDto
{
	public class ReceiveMessageByIdDto
	{
        [JsonPropertyName("name")]
        public string? name { get; set; }
        [JsonPropertyName("mail")]
        public string? mail { get; set; }
        [JsonPropertyName("subject")]
        public string? subject { get; set; }
        [JsonPropertyName("message")]
        public string? message { get; set; }
        [JsonPropertyName("date")]
        public DateTime date { get; set; }
    }
}

