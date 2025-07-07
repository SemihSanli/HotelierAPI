using Hotelier.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        void BookingStatusChangeToApproved(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
    }
}
