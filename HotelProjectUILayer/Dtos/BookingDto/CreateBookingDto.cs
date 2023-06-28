using System;
namespace HotelProjectUILayer.Dtos.BookingDto
{
	public class CreateBookingDto
	{
        public string? name { get; set; }
        public string? mail { get; set; }
        public string? checkIn { get; set; }
        public string? checkOut { get; set; }
        public string? adultCount { get; set; }
        public string? childCount { get; set; }
        public string? roomCount { get; set; }
        public string? specialRequest { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
    }
}

