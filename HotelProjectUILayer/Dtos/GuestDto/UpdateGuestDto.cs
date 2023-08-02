
using System;
namespace HotelProjectUILayer.Dtos.GuestDto
{
	public class UpdateGuestDto
	{
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? city { get; set; }
    }
}

