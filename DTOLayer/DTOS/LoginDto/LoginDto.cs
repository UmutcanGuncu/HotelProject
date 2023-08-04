using System;
using System.ComponentModel.DataAnnotations;

namespace DTOLayer.DTOS.LoginDto
{
	public class LoginDto
	{
		[Required(ErrorMessage ="Lütfen E Posta Adresinizi Giriniz")]
		public string? Email { get; set; }
		[Required(ErrorMessage ="Lütfen Şifrenizi Giriniz")]
		public string? Password { get; set; }
	}
}

