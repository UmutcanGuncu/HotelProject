using System;
using AutoMapper;
using DTOLayer.DTOS.RegisterDto;
using DTOLayer.DTOS.RoomDto;
using EntityLayer.Concrete;

namespace HotelProjectWebApi.Mapping
{
	public class AutoMapperConfig:Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<Room, RoomAddDto>().ReverseMap();
			CreateMap<Room, RoomUpdateDto>().ReverseMap();
			CreateMap<AppUser, SignUpDto>().ReverseMap();
		}
	}
}

