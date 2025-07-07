using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _worklocationDal;

        public WorkLocationManager(IWorkLocationDal worklocationDal)
        {
            _worklocationDal = worklocationDal;
        }

        public void TDelete(WorkLocation t)
        {
            _worklocationDal.Delete(t);
        }

        public WorkLocation TGetByID(int id)
        {
           return _worklocationDal.GetByID(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _worklocationDal.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _worklocationDal.Insert(t);
        }

        public void TUpdate(WorkLocation t)
        {
            _worklocationDal.Update(t);
        }
    }
}
