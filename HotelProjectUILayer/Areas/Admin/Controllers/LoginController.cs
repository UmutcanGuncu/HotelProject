using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DTOLayer.DTOS.LoginDto;
using DTOLayer.DTOS.RegisterDto;
using HotelProjectUILayer.Models;
using Microsoft.AspNetCore.Mvc;


namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult SignUp()//Kayıt Ol
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            var stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7215/api/Register", stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Staff");
            }
            else {
               
               var value=await responseMessage.Content.ReadAsStreamAsync();
                var result = JsonSerializer.Deserialize<ContentvM>(value);
                ViewBag.Deneme = $"{result}";
            }
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()//Giriş Yap
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(LoginDto model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            var stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7215/api/Login", stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Staff");
            }
            return View();
        }
    }
}

