using System;
using System.Text.Json;
using HotelProjectUILayer.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Dashboard
{
	public class _DashboardLast6Bookings:ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast6Bookings(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/Booking/ListBookingLast6");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var values = JsonSerializer.Deserialize<List<ResultLast6BookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

