using System;
using System.Text.Json;
using HotelProjectUILayer.Dtos.TestimonialDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Default
{
	public class _Testimonial:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _Testimonial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7215/api/Testimonial");
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStreamAsync();
				var data = JsonSerializer.Deserialize<List<ResultTestimonialDto>>(jsonData);
				return View(data);
			}
			return View();
		}
	}
}

