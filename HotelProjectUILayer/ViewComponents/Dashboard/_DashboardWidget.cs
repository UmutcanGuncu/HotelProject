using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUILayer.ViewComponents.Dashboard
{
	public class _DashboardWidget: ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidget(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7215/api/DashboardWidgets/StaffCount");
			var staffCount = await responseMessage.Content.ReadAsStringAsync();
			ViewBag.StaffCount = staffCount;

			var responseMessage2 = await client.GetAsync("https://localhost:7215/api/DashboardWidgets/BookingCount");
			var bookingCount = await responseMessage2.Content.ReadAsStringAsync();
			ViewBag.BookingCount = bookingCount;

			var responseMessage3 = await client.GetAsync("https://localhost:7215/api/DashboardWidgets/AppUserCount");
			var appUserCount = await responseMessage3.Content.ReadAsStringAsync();
			ViewBag.AppUserCount = appUserCount;

			var responseMessage4 = await client.GetAsync("https://localhost:7215/api/DashboardWidgets/RoomCount");
			var roomCount = await responseMessage4.Content.ReadAsStringAsync();
			ViewBag.RoomCount = roomCount;
			return View();
		}
	}
}

