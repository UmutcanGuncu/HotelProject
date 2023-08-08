using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDAL _staffDal;

        public StaffManager(IStaffDAL staffDal)
        {
            _staffDal = staffDal;
        }

        public void Delete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff GetById(Guid id)
        {
            return _staffDal.GetById(id);
        }

        public List<Staff> GetList()
        {
            return _staffDal.GetList();
        }

        public int GetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void Insert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public List<Staff> Last4Staff()
        {
            return _staffDal.Last4Staff();
        }

        public void Update(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}

