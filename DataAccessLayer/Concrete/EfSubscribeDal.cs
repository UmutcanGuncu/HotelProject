using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDAL
    {
        public EfSubscribeDal(HotelContext.Context context) : base(context)
        {
        }
    }
}

