using System;
namespace HotelProjectUILayer.Dtos.BookingDto
{
	public class UpdateBookingDto
	{
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? mail { get; set; }
        public string? checkIn { get; set; }
        public string? checkOut { get; set; }
        public string? adultCount { get; set; }
        public string? childCount { get; set; }
        public string? roomCount { get; set; }
        public string? description { get; set; }
        public string? SpecialRequest { get; set; }
        public string? status { get; set; }
    }
}

