using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDAL
    {
        public EfSubscribeDal(HotelContext context) : base(context)
        {
        }
    }
}

