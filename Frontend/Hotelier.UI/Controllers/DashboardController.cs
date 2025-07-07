using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
