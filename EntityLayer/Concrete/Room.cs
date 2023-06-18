using System;
namespace EntityLayer.Concrete
{
	public class Room
	{
		public Guid Id { get; set; }
		public string? RoomNumber { get; set; }
		public string? CoverImage { get; set; }
		public float Price { get; set; }
		public string? Title { get; set; }
		public string? BedCount { get; set; } //Yatak Sayısı
		public string? BathCount { get; set; } //Banyo Sayısı
		public string? Wifi { get; set; }
		public string? Description { get; set; }
	}
}

