using System;
using System.ComponentModel.DataAnnotations;

namespace DTOLayer.DTOS.RegisterDto
{
    public class SignUpDto
    {
        [Required(ErrorMessage = "Ad Boş Geçilemez")]
        [Display(Name="İsim")]
        
		public string? Name { get; set; }
        [Required(ErrorMessage = "Soyad Boş Geçilemez")]
        public string? Surname { get; set; }
        [Required(ErrorMessage = "Şehir Boş Geçilemez")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "E Posta Boş Geçilemez")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Boş Geçilemez")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Şifre Boş Geçilemez")]
        [Compare("ConfirmPassword",ErrorMessage ="Şifreler Birbiri İle Uyuşmuyor")]
        [DataType(DataType.Password)]
        [MinLength(7,ErrorMessage ="Şifreniz Minimum 7 Karakter Olmalıdır")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrarı Boş Geçilemez")]
        [MinLength(7, ErrorMessage = "Şifreniz Minimum 7 Karakter Olmalıdır")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
		
	}
}

