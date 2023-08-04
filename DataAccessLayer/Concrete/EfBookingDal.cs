using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataAccessLayer.Concrete
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly Context _context;
        public EfBookingDal(Context context) : base(context)
        {
            _context = context;
        }

        

        public void Aprovved(Guid id)
        {
                var item =  _context.Bookings.Where(x => x.Id == id).FirstOrDefault();
                item.Status = "Onaylandı"; //tracking mekanizması çalıştığından update methodunu kullanmaya gerek yok
                _context.SaveChanges();
        }

        public void Cancelled(Guid id)
        {
            var item = _context.Bookings.Where(x => x.Id == id).FirstOrDefault();
            item.Status = "İptal Edildi";
            _context.SaveChanges();
        }

        public void Waiting(Guid id)
        {
            var item = _context.Bookings.Where(x => x.Id == id).FirstOrDefault();
            item.Status = "Müşteri Aranacak";
            _context.SaveChanges();
        }
    }
}

