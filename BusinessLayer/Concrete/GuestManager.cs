using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void Delete(Guest t)
        {
            _guestDal.Delete(t);
        }

        public Guest GetById(Guid id)
        {
            return _guestDal.GetById(id);
        }

        public List<Guest> GetList()
        {
            return _guestDal.GetList();
        }

        public void Insert(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void Update(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}

