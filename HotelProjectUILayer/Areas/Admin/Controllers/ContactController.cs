using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HotelProjectUILayer.Dtos.ContactDto;
using HotelProjectUILayer.Dtos.SendMessageDto;
using Microsoft.AspNetCore.Mvc;



namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public ContactController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Inbox ()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/Contact");
            var sendMessage = await client.GetAsync("https://localhost:7215/api/SendMessage/SendMessageCount");
            var jsonDataSendMessage = await sendMessage.Content.ReadAsStringAsync();
            ViewBag.SendMessage = jsonDataSendMessage;
            var inboxMessage = await client.GetAsync("https://localhost:7215/api/Contact/ContactCount");
            var jsonDataInboxMessage = await inboxMessage.Content.ReadAsStringAsync();
            ViewBag.Inbox = jsonDataInboxMessage;
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var values = JsonSerializer.Deserialize<List<InboxContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage model)
        {
            model.senderMail = "admin@gmail.com";
            model.senderName = "Admin";
            model.date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _clientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7215/api/SendMessage",stringContent);
            return Redirect("/Admin/Contact/SendBox");
        }

        public async Task<IActionResult> SendBox()
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7215/api/SendMessage");
            var sendMessage = await client.GetAsync("https://localhost:7215/api/SendMessage/SendMessageCount");
            var jsonDataSendMessage = await sendMessage.Content.ReadAsStringAsync();
            ViewBag.SendMessage = jsonDataSendMessage;
            var inboxMessage = await client.GetAsync("https://localhost:7215/api/Contact/ContactCount");
            var jsonDataInboxMessage = await inboxMessage.Content.ReadAsStringAsync();
            ViewBag.Inbox = jsonDataInboxMessage;

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var values = JsonSerializer.Deserialize<List<ResultSendBoxDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task <IActionResult> SendMessageDetails(Guid id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7215/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStreamAsync();
                var value = JsonSerializer.Deserialize<GetMessageByIdDto>(jsonData);
                return View(value);
            }
            return View();
        }
        public async Task <IActionResult> ReceiveMessageDetails(Guid id)
        {
            var client = _clientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7215/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonSerializer.Deserialize<ReceiveMessageByIdDto>(jsonData);
                return View(value);
            }
            return View();
        }
        public PartialViewResult _SideBarContactPartial()
        {
            
            
            return PartialView();
        }
    }
}

