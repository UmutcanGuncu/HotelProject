using System;
namespace HotelProjectUILayer.Dtos.RoleDto
{
	public class RoleAssignDto
	{
		public string? RoleName { get; set; }
		public Guid RoleId { get; set; }
		public bool RoleExist { get; set; }
	}
}

