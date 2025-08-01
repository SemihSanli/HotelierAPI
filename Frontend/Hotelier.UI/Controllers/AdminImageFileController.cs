﻿using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Hotelier.UI.Controllers
{
    public class AdminImageFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile file)
        {
            var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            var bytes = stream.ToArray();

            ByteArrayContent byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(byteArrayContent, "files", file.FileName);
            var httpclient = new HttpClient();
            await httpclient.PostAsync("http://localhost:5041/api/FileImage", multipartFormDataContent );
            return View();
        }
    }
}
