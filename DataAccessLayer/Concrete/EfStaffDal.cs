using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfStaffDal : GenericRepository<Staff>,IStaffDAL
    {
        public EfStaffDal(HotelContext.Context context) : base(context)
        {
        }

       
    }
}

