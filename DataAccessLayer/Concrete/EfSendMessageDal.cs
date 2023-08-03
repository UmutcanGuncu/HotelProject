using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfSendMessageDal : GenericRepository<SendMessage>, ISendMessageDal
    {
        public EfSendMessageDal(HotelContext context) : base(context)
        {
        }
    }
}

