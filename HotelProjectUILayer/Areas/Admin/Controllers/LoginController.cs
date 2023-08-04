using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DTOLayer.DTOS.LoginDto;
using DTOLayer.DTOS.RegisterDto;
using EntityLayer.Concrete;
using HotelProjectUILayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginController(SignInManager<AppUser> signInManager, IHttpClientFactory httpClientFactory,UserManager<AppUser> userManager)
        {
            _httpClientFactory = httpClientFactory;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult SignUp()//Kayıt Ol
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser appUser = new AppUser()
            {
                UserName = model.UserName,
                Name = model.Name,
                Surname = model.Surname,
                City = model.City,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber


            };
            //var user = _mapper.Map<AppUser>(model); maplame de hata vae sonra bakacam
            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (!result.Succeeded)
            {

                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
                return View(ModelState);
            }

            return Redirect("/Admin/Login/SignIn");
            /* if(!ModelState.IsValid)
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
             return View();*/
        }
        [HttpGet]
        public IActionResult SignIn()//Giriş Yap
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(LoginDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                var result = await _signInManager.PasswordSignInAsync(user, model.Password, true,false);
                if (result.Succeeded)
                {
                    return Redirect("/Admin/Staff/Index");
                }
                else
                    {

                    return View();
                }
            }
            return View();
            /*if(!ModelState.IsValid)
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
            return View();*/
        }
    }
}

