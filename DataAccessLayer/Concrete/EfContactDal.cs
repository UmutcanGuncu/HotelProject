using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfContactDal : GenericRepository<Contact>,IContactDal
    {
        private readonly Context _context;
        public EfContactDal(Context context) : base(context)
        {
            _context = context;
        }

        public int ContactCount()
        {
            return _context.Contacts.Count();
        }
    }
}

