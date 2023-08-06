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
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;

        public WorkLocationController(IWorkLocationService workLocationService)
        {
            _workLocationService = workLocationService;
        }

        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.Insert(workLocation);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetWorkLocation()
        {
            var values =_workLocationService.GetList();
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation workLocation)
        {
            _workLocationService.Update(workLocation);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(Guid id)
        {
            var value = _workLocationService.GetById(id);
            _workLocationService.Delete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkLocation(Guid id)
        {
            var value = _workLocationService.GetById(id);
            return Ok(value);
        }
    }
}

