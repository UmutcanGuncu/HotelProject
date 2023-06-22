using System;
namespace HotelProjectUILayer.Dtos.ServiceDto
{
	public class UpdateServiceDto
	{
        public Guid id { get; set; }
        public string? title { get; set; }
        public string? decription { get; set; }
        public string? icon { get; set; }
    }
}

