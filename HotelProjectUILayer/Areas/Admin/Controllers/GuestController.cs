using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HotelProjectUILayer.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;


namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class GuestController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public GuestController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task <IActionResult> Index()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/Guest");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var values = JsonSerializer.Deserialize<List<ResultGuestDto>> (jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateGuest(Guid id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7215/api/Guest/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var value = JsonSerializer.Deserialize<UpdateGuestDto>(jsonData);
                return View(value);

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateGuest(UpdateGuestDto model)
        {
            if (ModelState.IsValid)
            {
                var client = _clientFactory.CreateClient();
                var jsonData = JsonSerializer.Serialize(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7215/api/Guest", stringContent);
                return Redirect("/Admin/Guest/Index");
            }
            return View();
        
        }
        [HttpGet]
        public  IActionResult AddGuest()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGuest(CreateGuestDto model)
        {
            if (ModelState.IsValid)
            {
                var client = _clientFactory.CreateClient();
                var jsonData = JsonSerializer.Serialize(model);
                StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
                var responseMessage = await client.PostAsync("https://localhost:7215/api/Guest",stringContent);
                if(responseMessage.IsSuccessStatusCode)
                {
                    return Redirect("/Admin/Guest/Index");
                }
            }
            return View();
        }
        public async Task<IActionResult> DeleteGuest(Guid id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7215/api/Guest/{id}");
            return Redirect("/Admin/Guest/Index");
        }
    }
}

