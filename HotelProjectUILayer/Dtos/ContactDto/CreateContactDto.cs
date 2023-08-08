using System;
using System.Text.Json.Serialization;
using EntityLayer.Concrete;

namespace HotelProjectUILayer.Dtos.ContactDto
{
	public class CreateContactDto
	{
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
        [JsonPropertyName("messageCategoryId")]
        public Guid MessageCategoryId { get; set; }
        [JsonPropertyName("messageCategory")]
        public MessageCategory? MessageCategory { get; set; }
    }
}

