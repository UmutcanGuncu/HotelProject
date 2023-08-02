using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HotelProjectUILayer.Dtos.AboutUsDto;
using HotelProjectUILayer.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;



namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class AdminAboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/AboutUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var result = JsonSerializer.Deserialize<List<ResultAboutUsDto>>(jsonData);
                return View(result);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAbout(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7215/api/AboutUs/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var result = JsonSerializer.Deserialize<UpdateAboutUsDto>(jsonData);
                return View(result);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutUsDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7215/api/AboutUs",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/AdminAbout/Index");
            }
            return View(model.id);
        }
    }
}

