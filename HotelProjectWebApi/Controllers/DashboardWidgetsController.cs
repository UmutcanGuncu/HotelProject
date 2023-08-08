using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;
        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _appUserService = appUserService;
            _bookingService = bookingService;
            _roomService = roomService;
            _staffService = staffService;
        }

        [HttpGet("AppUserCount")]
        public IActionResult GetAppUserCount()
        {
            var value = _appUserService.AppUserCount();
            return Ok(value);
        }
        [HttpGet("BookingCount")]
        public IActionResult GetBookingCount()
        {
            var value = _bookingService.BookingCount();
            return Ok(value);
        }
        [HttpGet("RoomCount")]
        public IActionResult GetRoomCount()
        {
            var value = _roomService.RoomCount();
            return Ok(value);
        }
        [HttpGet("StaffCount")]
        public IActionResult GetStaffCount()
        {
            var value = _staffService.GetStaffCount();
            return Ok(value);
        }
       

    }
}

