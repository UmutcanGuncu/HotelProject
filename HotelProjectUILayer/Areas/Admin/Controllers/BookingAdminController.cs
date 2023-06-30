using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HotelProjectUILayer.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;


namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/Booking");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
               var result =JsonSerializer.Deserialize<List<ResultBookingDto>>(jsonData);
                return View(result);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBooking(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7215/api/Booking/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var value = JsonSerializer.Deserialize<UpdateBookingDto>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            var stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:7215/api/Booking/",stringContent);
            return Redirect("/Admin/BookingAdmin/Index");
        }

        public async Task<IActionResult> ApproveBooking(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7215/api/Booking/approved/{id}");
            return Redirect("/Admin/BookingAdmin/Index");
        }
        public async Task<IActionResult> CancelBooking(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7215/api/Booking/cancelled/{id}");
             return Redirect("/Admin/BookingAdmin/Index");
        }
        public async Task<IActionResult> WaitBooking(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7215/api/Booking/waiting/{id}");
            return Redirect("/Admin/BookingAdmin/Index");
        }

    }
}

