using System;
using System.Text.Json.Serialization;

namespace HotelProjectUILayer.Dtos.MessageCategoryDto
{
	public class ResultMessageCategoryDto
	{
        [JsonPropertyName("messageCategoryId")]
        public Guid messageCategoryId { get; set; }
        [JsonPropertyName("categoryName")]
        public string? categoryName { get; set; }
    }
}

