using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidAPI.Consume.Models;

namespace RapidAPI.Consume.Controllers
{
    public class IMDBControler : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<IMDBMovieAPIViewModel> aPIViewModels = new List<IMDBMovieAPIViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "160c62f520msh829ef427e1a1a14p1c256djsnfbe498e89083" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                aPIViewModels=JsonConvert.DeserializeObject<List<IMDBMovieAPIViewModel>>(body);
                return View(aPIViewModels);
            }
           
        }
    }
}
