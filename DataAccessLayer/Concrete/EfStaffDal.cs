using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfStaffDal : GenericRepository<Staff>,IStaffDAL
    {
        private readonly Context _context;
        public EfStaffDal(Context context) : base(context)
        {
            _context = context;
        }

        public int GetStaffCount()
        {
            var value = _context.Staffes.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
           return _context.Staffes.Take(4).ToList();
        }
    }
}

