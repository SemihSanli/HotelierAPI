using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
