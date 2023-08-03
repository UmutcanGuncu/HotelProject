using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HotelProjectUILayer.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class ImageFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Index(IFormFile file)
        {
            var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            var bytes = stream.ToArray();
            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(byteArrayContent, "file", file.FileName);
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.PostAsync("https://localhost:7215/api/FileImage",multipartFormDataContent);
            return View();
        }
    }
}

