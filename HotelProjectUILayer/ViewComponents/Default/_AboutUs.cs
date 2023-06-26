using System;
using System.Text.Json;
using HotelProjectUILayer.Dtos.AboutUsDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _AboutUs:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUs(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7215/api/AboutUs");
			if(responseMessage.IsSuccessStatusCode)
			{
				var json = await responseMessage.Content.ReadAsStreamAsync();
				var data = JsonSerializer.Deserialize<List<ResultAboutUsDto>>(json);
				return View(data);
			}
			return View();
		}
	}
}

