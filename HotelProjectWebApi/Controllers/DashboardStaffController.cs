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
    public class DashboardStaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public DashboardStaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet("Last4StaffList")]
        public IActionResult Last4StaffList()
        {
            var values = _staffService.Last4Staff();
            return Ok(values);
        }
    }
}

