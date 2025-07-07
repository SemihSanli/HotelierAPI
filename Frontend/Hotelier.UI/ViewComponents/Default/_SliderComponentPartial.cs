using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.ViewComponents.Default
{
    public class _SliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
