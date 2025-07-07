using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.ViewComponents.Default
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
