using System;
using System.Text.Json;
using HotelProjectUILayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _Staff:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _Staff(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/Staff/Last4Staff");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var data = JsonSerializer.Deserialize<List<StaffListViewModel>>(jsonData);
                return View(data);
            }
            return View();
        }

    }
}

