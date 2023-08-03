using System;
namespace HotelProjectUILayer.Dtos.SendMessageDto
{
	public class GetMessageByIdDto
	{
        public string? title { get; set; }
        public string? content { get; set; }
        public string? receiverName { get; set; }
        public string? receiverMail { get; set; }
        public string? senderName { get; set; }
        public string? senderMail { get; set; }
        public DateTime date { get; set; }
    }
}

