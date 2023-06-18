using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDAL
    {
        public EfTestimonialDal(HotelContext context) : base(context)
        {
        }
    }
}

