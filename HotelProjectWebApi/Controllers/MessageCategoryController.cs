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
    public class MessageCategoryController : ControllerBase
    {
        private readonly IMessageCategoryService _messageCategoryService;

        public MessageCategoryController(IMessageCategoryService messageCategoryService)
        {
            _messageCategoryService = messageCategoryService;
        }

        [HttpPut]
        public IActionResult AddMessageCategory(MessageCategory messageCategory)
        {
            _messageCategoryService.Insert(messageCategory);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _messageCategoryService.GetList();
            return Ok(values);
        }
    }
}

