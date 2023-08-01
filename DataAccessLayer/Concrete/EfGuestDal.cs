using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfGuestDal : GenericRepository<Guest>
    {
        public EfGuestDal(HotelContext context) : base(context)
        {
        }
    }
}

