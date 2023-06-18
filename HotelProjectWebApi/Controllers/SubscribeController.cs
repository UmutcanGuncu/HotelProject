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
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.Insert(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(Guid id)
        {
            var value = _subscribeService.GetById(id);
            _subscribeService.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.Update(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(Guid id)
        {
            var currentValue = _subscribeService.GetById(id);
            return Ok(currentValue);
        }
    }
}

