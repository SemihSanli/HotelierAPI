﻿using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.Repositories;
using Hotelier.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {

        }

        public int AppUserCount()
        {
            var context = new Context();
            var value = context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var context = new Context();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }

        public List<AppUser> UsersListWithWorkLocations()
        {
            var context = new Context();
            //var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWithWorkLocationDto
            //{
            //    Name = y.Name,
            //    Surname = y.Surname,
            //    WorkLocationID = y.WorkLocationID,
            //    WorkLocationName = y.WorkLocation.WorkLocationName
            //});
            var values = context.Users.ToList();
            return values.ToList();
        }
    }
}
