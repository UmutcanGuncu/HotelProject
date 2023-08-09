using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DTOLayer.DTOS.LoginDto;
using DTOLayer.DTOS.RegisterDto;
using EntityLayer.Concrete;
using HotelProjectUILayer.Dtos.MessageCategoryDto;
using HotelProjectUILayer.Dtos.WorkLocationDto;
using HotelProjectUILayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public async Task<IActionResult> SignUp()//Kayıt Ol
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/WorkLocation");
            var jsonData = await responseMessage.Content.ReadAsStreamAsync();
            var values = JsonSerializer.Deserialize<List<ListWorkLocationDto>>(jsonData);
            List<SelectListItem> values2 = (from x in values
                                            select new SelectListItem
                                            {
                                                Text = x.Name,
                                                Value = x.WorkLocationId.ToString()
                                            }).ToList();
            ViewBag.v = values2;
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
                PhoneNumber = model.PhoneNumber,
                WorkLocationId= model.workLocationId,
                Country = model.Country,
                Gender = model.Gender
                

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
            
        }
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Default/Index");
        }
    }
}

