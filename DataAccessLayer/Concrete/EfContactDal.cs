using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfContactDal : GenericRepository<Contact>,IContactDal
    {
        public EfContactDal(HotelContext context) : base(context)
        {
        }
    }
}

