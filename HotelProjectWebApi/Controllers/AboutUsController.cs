using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;
        
        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }
        [HttpGet]
        public IActionResult AboutUsList()
        {
            var values= _aboutUsService.GetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAboutUs(Guid id)
        {
            var value=_aboutUsService.GetById(id);
            _aboutUsService.Delete(value);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.Insert(aboutUs);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUs(Guid id)
        {
            var value = _aboutUsService.GetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.Update(aboutUs);
            return Ok();
        }
    }
}

