using Microsoft.AspNetCore.Mvc;

namespace Hotelier.UI.ViewComponents.Booking
{
    public class _BookingCoverComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
