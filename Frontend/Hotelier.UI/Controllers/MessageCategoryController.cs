using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
