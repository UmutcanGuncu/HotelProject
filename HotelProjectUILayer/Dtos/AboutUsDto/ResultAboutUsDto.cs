using System;
namespace HotelProjectUILayer.Dtos.AboutUsDto
{
	public class ResultAboutUsDto
	{
        public Guid id { get; set; }
        public string? title1 { get; set; }
        public string? title2 { get; set; }
        public string? content { get; set; }
        public int roomCount { get; set; }
        public int staffCount { get; set; }
        public int customerCount { get; set; }
    }
}

