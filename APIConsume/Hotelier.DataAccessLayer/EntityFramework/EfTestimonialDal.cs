﻿using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.Repositories;
using Hotelier.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {
            
        }
    }
}
