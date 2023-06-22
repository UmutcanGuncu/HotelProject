using System;
using System.ComponentModel.DataAnnotations;

namespace DTOLayer.DTOS.RoomDto
{
	public class RoomUpdateDto
	{
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Oda Numarası Boş Geçilemez")]
        public string? RoomNumber { get; set; }
        public string? CoverImage { get; set; }
        [Required(ErrorMessage = "Fiyat Boş Geçilemez")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Başlık Boş Geçilemez")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Yatak Sayısı Boş Geçilemez")]
        public string? BedCount { get; set; } //Yatak Sayısı
        [Required(ErrorMessage = "Banyo Sayısı Boş Geçilemez")]
        public string? BathCount { get; set; } //Banyo Sayısı
        public string? Wifi { get; set; }
        [Required(ErrorMessage = "Açıklama Boş Geçilemez")]
        public string? Description { get; set; }
    }
}

