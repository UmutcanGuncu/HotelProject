using System;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ContactController:ControllerBase
	{
		private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.Insert(contact);
            return Ok();
        }
        [HttpGet]
        public IActionResult ListContact()
        {
            var values= _contactService.GetList();
            return Ok(values);
        }
    }
}

