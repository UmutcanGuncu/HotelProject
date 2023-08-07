using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.HotelContext;
using HotelProjectWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        private readonly Context _context;
        public AppUserController(Context context, IAppUserService appUserService)
        {
            _appUserService = appUserService;
            _context = context;
        }

       


        [HttpGet("UserListWithWorkLocation")]
        public IActionResult UserListWithWorkLocation()
        {

            var values = _context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWorkLocationViewModel
            {
                Name = y.Name,
                Surname = y.Surname,
                City = y.City,
                Gender = y.Gender,
                Country = y.Country,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                WorkLocationId = y.WorkLocationId 
            }) ;
            return Ok(values);
        }
    }
}

