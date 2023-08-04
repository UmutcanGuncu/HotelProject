﻿using System;
using EntityLayer.Concrete;

namespace HotelProjectUILayer.Dtos.ContactDto
{
	public class CreateContactDto
	{
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
        public Guid MessageCategoryId { get; set; }
        public MessageCategory? MessageCategory { get; set; }
    }
}

