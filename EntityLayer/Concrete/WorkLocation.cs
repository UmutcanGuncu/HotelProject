using System;
namespace EntityLayer.Concrete
{
	public class WorkLocation
	{
		public Guid WorkLocationId { get; set; }
		public string? Name { get; set; }
		public string? City { get; set; }
		public List<AppUser>? AppUsers { get; set; }
	}
}

