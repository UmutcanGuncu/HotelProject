using System;
namespace HotelProjectUILayer.Dtos.BookingDto
{
	public class ResultBookingDto
	{
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? checkIn { get; set; }
        public string? checkOut { get; set; }
        public string? status { get; set; }
    }
}

