using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class WorklocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorklocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void Delete(WorkLocation t)
        {
            _workLocationDal.Delete(t);
        }

        public WorkLocation GetById(Guid id)
        {
            return _workLocationDal.GetById(id);
        }

        public List<WorkLocation> GetList()
        {
            return _workLocationDal.GetList();
        }

        public void Insert(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void Update(WorkLocation t)
        {
            _workLocationDal.Update(t);
        }
    }
}

