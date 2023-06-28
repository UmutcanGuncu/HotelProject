using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(HotelContext context) : base(context)
        {
        }
    }
}

