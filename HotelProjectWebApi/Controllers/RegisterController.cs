using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DTOLayer.DTOS.RegisterDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        public RegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
           
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            AppUser appUser = new AppUser()
            {
                UserName = model.UserName,
                Name=model.Name,
                Surname=model.Surname,
                City= model.City,
                Email=model.Email,
                PhoneNumber=model.PhoneNumber 


            };
            //var user = _mapper.Map<AppUser>(model); maplame de hata vae sonra bakacam
            var result =await _userManager.CreateAsync(appUser,model.Password);
            if(!result.Succeeded)
            {

                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
                return BadRequest(ModelState);
            }

            return Ok();
        }
        
    }
}

