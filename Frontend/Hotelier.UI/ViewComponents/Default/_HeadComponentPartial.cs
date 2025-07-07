using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.ViewComponents.Default
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
