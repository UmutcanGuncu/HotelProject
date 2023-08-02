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
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.Insert(guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(Guid id)
        {
            var value = _guestService.GetById(id);
            _guestService.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.Update(guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(Guid id)
        {
           var value= _guestService.GetById(id);
            return Ok(value);
        }
    }
}

