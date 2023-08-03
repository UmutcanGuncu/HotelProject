using System;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessLayer.Context
{
	public class HotelContext:IdentityDbContext<AppUser,AppRole,Guid>
	{
        public HotelContext(DbContextOptions<HotelContext> options):base(options)
		{

		}
        
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Staff> Staffes { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Contact> Contacts { get;set;}
    }
}

