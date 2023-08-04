using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfGuestDal : GenericRepository<Guest>, IGuestDal
    {
        public EfGuestDal(HotelContext.Context context) : base(context)
        {
        }
    }
}

