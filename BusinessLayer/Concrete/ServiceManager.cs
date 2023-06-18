using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServicesService
    {
        private readonly IServicesDAL _servicesDal;

        public ServiceManager(IServicesDAL servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void Delete(Services t)
        {
            _servicesDal.Delete(t);
        }

        public Services GetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public List<Services> GetList()
        {
            return _servicesDal.GetList();
        }

        public void Insert(Services t)
        {
            _servicesDal.Insert(t);
        }

        public void Update(Services t)
        {
            _servicesDal.Update(t);
        }
    }
}

