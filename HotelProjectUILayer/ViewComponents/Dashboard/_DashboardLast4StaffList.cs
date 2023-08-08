using System;
using System.Text.Json;
using HotelProjectUILayer.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Dashboard
{
	public class _DashboardLast4StaffList:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4StaffList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7215/api/DashboardStaff/Last4StaffList");
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStreamAsync();
				var values = JsonSerializer.Deserialize<List<ResultLast4StaffDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

