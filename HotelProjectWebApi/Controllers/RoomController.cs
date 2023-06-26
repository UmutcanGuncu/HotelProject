using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values=_roomService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.Insert(room);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(Guid id)
        {
            var currentValue = _roomService.GetById(id);
            _roomService.Delete(currentValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.Update(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(Guid id)
        {
           var currentValue= _roomService.GetById(id);
            return Ok(currentValue);
        }

    }
}

