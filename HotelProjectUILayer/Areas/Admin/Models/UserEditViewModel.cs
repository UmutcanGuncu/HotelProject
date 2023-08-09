using System;
namespace HotelProjectUILayer.Areas.Admin.Models
{
	public class UserEditViewModel
	{
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Email { get; set; }
		public string? Username { get; set; }
		public string? City { get; set; }
		public string? Country { get; set; }
		public string? Password { get; set; }
		public string? ConfirmPassword { get; set; }
	}
}

