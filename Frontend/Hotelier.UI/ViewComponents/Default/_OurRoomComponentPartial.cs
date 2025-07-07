using Hotelier.UI.DTOs.RoomDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelier.UI.ViewComponents.Default
{
    public class _OurRoomComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _OurRoomComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5041/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDTOs>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
