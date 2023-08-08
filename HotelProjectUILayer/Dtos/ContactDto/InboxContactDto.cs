using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.ContactDto
{
	public class InboxContactDto
	{
        [JsonPropertyName("contactId")]
        public Guid Id { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("mail")]
        public string? Mail { get; set; }
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
    }
}

