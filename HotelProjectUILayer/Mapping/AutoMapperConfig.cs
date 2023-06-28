using System;
using AutoMapper;
using EntityLayer.Concrete;
using HotelProjectUILayer.Dtos.AboutUsDto;
using HotelProjectUILayer.Dtos.BookingDto;
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
        }
	}
}

