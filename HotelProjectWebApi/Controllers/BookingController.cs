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
    public class BookingController : ControllerBase
    {

        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking Booking)
        {
            _bookingService.Insert(Booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(Guid Id)
        {
            var value = _bookingService.GetById(Id);
            _bookingService.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking Bookings)
        {
            _bookingService.Update(Bookings);
            return Ok();
        }
        [HttpGet("approved/{id}")]
        public IActionResult Approved(Guid id)
        {
            _bookingService.Approved(id);
            return Ok();
        }
        [HttpGet("cancelled/{id}")]
        public IActionResult Cancelled(Guid id)
        {
            _bookingService.Cancelled(id);
            return Ok();
        }
        [HttpGet("waiting/{id}")]
        public IActionResult Waiting(Guid id)
        {
            _bookingService.Waiting(id);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(Guid id)
        {
            var currentValue = _bookingService.GetById(id);
            return Ok(currentValue);
        }
    }
}

