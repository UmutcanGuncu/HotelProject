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

        public Staff GetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public List<Staff> GetList()
        {
            return _staffDal.GetList();
        }

        public void Insert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void Update(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}

