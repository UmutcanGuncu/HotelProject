using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDAL
    {
        public EfTestimonialDal(HotelContext.Context context) : base(context)
        {
        }
    }
}

