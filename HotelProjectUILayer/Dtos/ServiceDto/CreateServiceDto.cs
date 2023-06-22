using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProjectUILayer.Dtos.ServiceDto
{
	public class CreateServiceDto
	{
        [Required(ErrorMessage ="Başlık Giriniz")]
        [StringLength(80,ErrorMessage ="Lütfen En Fazla 80 Karakter Giriniz")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Açıklama Giriniz")]
        [StringLength(200, ErrorMessage = "Lütfen En Fazla 200 Karakter Giriniz")]
        public string? Decription { get; set; }
        [Required(ErrorMessage = "Icon Giriniz")]
        public string? Icon { get; set; }
    }
}

