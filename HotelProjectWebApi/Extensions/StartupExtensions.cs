using System;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace HotelProjectWebApi.Extensions
{
	public static class StartupExtensions
	{
		public static void ScopedExtensions(this IServiceCollection services)
		{
            services.AddScoped<IStaffDAL, EfStaffDal>();
            services.AddScoped<IStaffService, StaffManager>();
			services.AddScoped<IRoomDal, EFRoomDal>();
			services.AddScoped<IRoomService, RoomManager>();
			services.AddScoped<IServicesDAL, EfServiceDal>();
			services.AddScoped<IServicesService, ServiceManager>();
			services.AddScoped<ISubscribeDAL, EfSubscribeDal>();
			services.AddScoped<ISubscribeService, SubscribeManager>();
			services.AddScoped<ITestimonialDAL, EfTestimonialDal>();
			services.AddScoped<ITestimonialService, TestimonialManager>(); 
        }
	}
}

