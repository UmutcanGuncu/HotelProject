using System;
namespace HotelProjectUILayer.Dtos.RoomDto
{
	public class UpdateRoomDto
	{
        public Guid id { get; set; }
        public string? roomNumber { get; set; }
        public string? coverImage { get; set; }
        public float price { get; set; }
        public string? title { get; set; }
        public string? bedCount { get; set; } //Yatak Sayısı
        public string? bathCount { get; set; } //Banyo Sayısı
        public string? wifi { get; set; }
        public string? description { get; set; }
    }
}

