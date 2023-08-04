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
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values= _sendMessageService.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.Insert(sendMessage);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(Guid id)
        {
            var value = _sendMessageService.GetById(id);
            _sendMessageService.Delete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(Guid id)
        {
            var value = _sendMessageService.GetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage sendMessage)
        {
            _sendMessageService.Update(sendMessage);
            return Ok();
        }
        [HttpGet("SendMessageCount")]
        public IActionResult SendMessageCount()
        {
            var value = _sendMessageService.SendMessageCount();
            return Ok(value);
        }
    }
}
