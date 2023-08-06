using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HotelProjectUILayer.Dtos.WorkLocationDto;
using Microsoft.AspNetCore.Mvc;



namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class WorkLocationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WorkLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/WorkLocation");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var values = JsonSerializer.Deserialize<List<ResultWorkLocationDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateWorkLocation(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7215/api/WorkLocation/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var value = JsonSerializer.Deserialize<UpdateWorkLocationDto>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateWorkLocation(UpdateWorkLocationDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7215/api/WorkLocation", stringContent);
            return Redirect("/Admin/WorkLocation/Index");
        }
        public async Task<IActionResult> DeleteWorkLocation(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7215/api/WorkLocation/{id}");
            return Redirect("/Admin/WorkLocation/Index");
        }
        [HttpGet]
        public IActionResult AddWorkLocation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddWorkLocation(CreateWorkLocationDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7215/api/WorkLocation",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/WorkLocation/Index");
            }
            return View();
        }
    }
}

