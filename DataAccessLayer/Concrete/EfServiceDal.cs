using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfServiceDal : GenericRepository<Services>,IServicesDAL
    {
        public EfServiceDal(HotelContext context) : base(context)
        {
        }
    }
}

