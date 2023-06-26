using System;
using System.Text.Json;
using HotelProjectUILayer.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _OurRoom:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _OurRoom(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7215/api/Room");
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStreamAsync();
				var data = JsonSerializer.Deserialize<List<ResultRoomDto>>(jsonData);
				return View(data);
			}			
			return View();
		}
	}
}

