using System;
using System.Text.Json;
using HotelProjectUILayer.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _Services:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _Services(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7215/api/Service");
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStreamAsync();
				var data = JsonSerializer.Deserialize<List<ResultServiceDto>>(jsonData);
				return View(data);
			}
			return View();
		}
		
	}
}

