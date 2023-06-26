using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfAboutUsDal : GenericRepository<AboutUs>, IAboutUsDal
    {
        public EfAboutUsDal(HotelContext context) : base(context)
        {
        }
    }
}

