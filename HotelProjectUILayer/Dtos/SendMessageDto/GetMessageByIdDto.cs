using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.SendMessageDto
{
	public class GetMessageByIdDto
	{
        [JsonPropertyName("title")]
        public string? title { get; set; }
        [JsonPropertyName("content")]
        public string? content { get; set; }
        [JsonPropertyName("receiverName")]
        public string? receiverName { get; set; }
        [JsonPropertyName("receiverMail")]
        public string? receiverMail { get; set; }
        [JsonPropertyName("senderName")]
        public string? senderName { get; set; }
        [JsonPropertyName("senderMail")]
        public string? SenderMail { get; set; }
        [JsonPropertyName("date")]
        public DateTime date { get; set; }

    }
}

