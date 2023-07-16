using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiJwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Test()
        {
            return Ok(new CreateToken().TokenCreate());
        }
        [HttpGet("[action]")]
        public IActionResult AdminTest()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }
        [HttpGet("[action]")]
        [Authorize]
        public IActionResult Test2()
        {
            return Ok("Hoşgeldiniz");
        }
        [HttpGet("[action]")]
        [Authorize(Roles ="Admin,Visitor")]
        public IActionResult Test3()
        {
            return Ok("Giriş Yapıldı");
        }
    }
}

