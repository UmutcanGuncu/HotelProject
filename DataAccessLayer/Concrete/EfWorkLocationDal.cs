using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EfWorkLocationDal : GenericRepository<WorkLocation>, IWorkLocationDal
    {
        public EfWorkLocationDal(Context context) : base(context)
        {
        }
    }
}

