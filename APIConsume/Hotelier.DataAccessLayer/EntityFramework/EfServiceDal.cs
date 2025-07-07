using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.Repositories;
using Hotelier.EntityLayer;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfServiceDal:GenericRepository<Service>,IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {

        }
    }
}
