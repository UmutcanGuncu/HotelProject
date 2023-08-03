using System;
namespace HotelProjectUILayer.Dtos.ContactDto
{
	public class ReceiveMessageByIdDto
	{
       
        public string? name { get; set; }
        public string? mail { get; set; }
        public string? subject { get; set; }
        public string? message { get; set; }
        public DateTime date { get; set; }
    }
}

