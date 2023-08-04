using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfSendMessageDal : GenericRepository<SendMessage>, ISendMessageDal
    {
        private readonly Context _context;
        public EfSendMessageDal(Context context) : base(context)
        {
            _context = context;
        }

        public int SendMessageCount()
        {
            var value =_context.SendMessages.Count();
            return value;
        }
    }
}

