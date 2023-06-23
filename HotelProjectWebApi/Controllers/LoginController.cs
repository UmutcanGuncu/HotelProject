using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTOLayer.DTOS.LoginDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto model)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName=model.UserName
                   
                };
              var result=  await _signInManager.PasswordSignInAsync(user,model.Password,true,true);
                if(result.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }
    }
}

