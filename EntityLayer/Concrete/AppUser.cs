using System;
using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
	public class AppUser:IdentityUser<Guid>
	{
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? City { get; set; }
		public string? Department { get; set; }
		public string? ImageUrl { get; set; }
		public string? Gender { get; set; }
		public string? Country { get; set; }
        public Guid WorkLocationId { get; set; }
		public WorkLocation? WorkLocation { get; set; }
    }
}

