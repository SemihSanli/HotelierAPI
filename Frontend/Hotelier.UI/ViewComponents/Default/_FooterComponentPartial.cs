using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.ViewComponents.Default
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
