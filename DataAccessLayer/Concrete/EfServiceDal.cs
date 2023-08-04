using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfServiceDal : GenericRepository<Services>,IServicesDAL
    {
        public EfServiceDal(HotelContext.Context context) : base(context)
        {
        }
    }
}

