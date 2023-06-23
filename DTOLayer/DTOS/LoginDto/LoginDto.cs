using System;
using System.ComponentModel.DataAnnotations;

namespace DTOLayer.DTOS.LoginDto
{
	public class LoginDto
	{
		[Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Giriniz")]
		public string? UserName { get; set; }
		[Required(ErrorMessage ="Lütfen Şifrenizi Giriniz")]
		public string? Password { get; set; }
	}
}

