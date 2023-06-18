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
    public class ServiceController : ControllerBase
    {
        private readonly IServicesService _ServiceService;

        public ServiceController(IServicesService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _ServiceService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Services Service)
        {
            _ServiceService.Insert(Service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(Guid Id)
        {
            var value = _ServiceService.GetById(Id);
            _ServiceService.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Services services)
        {
            _ServiceService.Update(services);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(Guid id)
        {
            var currentValue = _ServiceService.GetById(id);
            return Ok(currentValue);
        }
    }
}


