using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void Delete(Booking t)
        {
            _bookingDal.Delete(t);
        }

        public Booking GetById(Guid id)
        {
            return _bookingDal.GetById(id);
        }

        public List<Booking> GetList()
        {
            return _bookingDal.GetList();
        }

        public void Insert(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void Update(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}

