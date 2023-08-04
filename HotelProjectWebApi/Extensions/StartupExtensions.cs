using System;
using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

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
			services.AddScoped<IAboutUsDal, EfAboutUsDal>();
			services.AddScoped<IAboutUsService, AboutUsManager>();
			services.AddScoped<IBookingDal, EfBookingDal>();
			services.AddScoped<IBookingService, BookingManager>();
			services.AddScoped<IContactDal, EfContactDal>();
			services.AddScoped<IContactService, ContactManager>();
			services.AddScoped<IGuestDal, EfGuestDal>();
			services.AddScoped<IGuestService, GuestManager>();
			services.AddScoped<ISendMessageDal, EfSendMessageDal>();
			services.AddScoped<ISendMessageService, SendMessageManager>();
			services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
			services.AddScoped<IMessageCategoryService, MessageCategoryManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
	}
}

