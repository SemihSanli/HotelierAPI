using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.ViewComponents.Dashboard
{
    public class _DashboardScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
