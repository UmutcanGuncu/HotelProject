using System;
using System.Text.Json;
using HotelProjectUILayer.Dtos.AppUserDto;
using HotelProjectUILayer.Dtos.WorkLocationDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents
{
    [ViewComponent(Name = "WorkLocationViewComponent")]
    public class WorkLocationViewComponent:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public WorkLocationViewComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IViewComponentResult> InvokeAsync()
		{
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/AppUser/UserListWithWorkLocation");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonDataId = await responseMessage.Content.ReadAsStreamAsync();
                var workLocationId = JsonSerializer.Deserialize<workLocationId>(jsonDataId);
                var responseMessageWorkLocation = await client.GetAsync($"https://localhost:7215/api/WorkLocation/{workLocationId}");
                var jsonDataWorkLocation = await responseMessageWorkLocation.Content.ReadAsStreamAsync();
                var workLocation = JsonSerializer.Deserialize<ResultWorkLocationDto>(jsonDataWorkLocation);
                return View(workLocation);
                
            }
			return View();
		}
	}
}

