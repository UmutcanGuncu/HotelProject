﻿using System;
namespace HotelProjectUILayer.Dtos.WorkLocationDto
{
	public class UpdateWorkLocationDto
	{
        public Guid workLocationId { get; set; } 
        public string? name { get; set; }
        public string? city { get; set; }
    }
}

