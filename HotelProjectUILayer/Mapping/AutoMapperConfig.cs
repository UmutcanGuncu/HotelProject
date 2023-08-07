using System;
using AutoMapper;
using EntityLayer.Concrete;
using HotelProjectUILayer.Dtos.AboutUsDto;
using HotelProjectUILayer.Dtos.AppUserDto;
using HotelProjectUILayer.Dtos.BookingDto;
using HotelProjectUILayer.Dtos.GuestDto;
using HotelProjectUILayer.Dtos.ServiceDto;

namespace HotelProjectUILayer.Mapping
{
	public class AutoMapperConfig:Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<ResultServiceDto, Services>().ReverseMap();
            CreateMap<UpdateServiceDto, Services>().ReverseMap();
            CreateMap<CreateServiceDto, Services>().ReverseMap();

            CreateMap<ResultAboutUsDto, AboutUs>().ReverseMap();
            CreateMap<UpdateAboutUsDto, AboutUs>().ReverseMap();

			CreateMap<CreateBookingDto, Booking>().ReverseMap();

			CreateMap<CreateGuestDto, Guest>().ReverseMap();
			CreateMap<UpdateGuestDto, Guest>().ReverseMap();

			CreateMap<ResultAppUserDto, AppUser>().ReverseMap();
			
        }
	}
}

