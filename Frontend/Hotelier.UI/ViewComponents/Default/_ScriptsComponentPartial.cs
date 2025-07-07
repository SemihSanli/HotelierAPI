using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.ViewComponents.Default
{
    public class _ScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
