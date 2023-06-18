using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfStaffDal : GenericRepository<Staff>,IStaffDAL
    {
        public EfStaffDal(HotelContext context) : base(context)
        {
        }

       
    }
}

