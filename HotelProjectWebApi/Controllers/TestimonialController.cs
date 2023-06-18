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
    [ApiController]
    [Route("api/[controller]")]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values =_testimonialService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.Insert(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(Guid Id)
        {
            var currentValue = _testimonialService.GetById(Id);
            _testimonialService.Delete(currentValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.Update(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(Guid Id)
        {
            var value = _testimonialService.GetById(Id);
            return Ok(value);
        }
    }
}

