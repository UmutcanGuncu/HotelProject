using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HotelProjectUILayer.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class RoomController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public RoomController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var values = JsonSerializer.Deserialize<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRoom(Guid id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7215/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var values = JsonSerializer.Deserialize<UpdateRoomDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDto model)
        {
            var client = _clientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:7215/api/Room",stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Room/Index");
            }
            return View();
        }
       
        public async Task<IActionResult> DeleteRoom(Guid id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7215/api/Room/{id}");
            return Redirect("/Admin/Room/Index");
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> AddRoom(CreateRoomDto model)
        {
            var client = _clientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7215/api/Room", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Room/Index");
            }
            return View();
            
        }
    }
}

