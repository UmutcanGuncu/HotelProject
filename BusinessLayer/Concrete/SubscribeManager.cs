using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDAL _subscribeDAL;

        public SubscribeManager(ISubscribeDAL subscribeDAL)
        {
            _subscribeDAL = subscribeDAL;
        }

        public void Delete(Subscribe t)
        {
            _subscribeDAL.Delete(t);
        }

        public Subscribe GetById(int id)
        {
            return _subscribeDAL.GetById(id);
        }

        public List<Subscribe> GetList()
        {
            return _subscribeDAL.GetList();
        }

        public void Insert(Subscribe t)
        {
            _subscribeDAL.Insert(t);
        }

        public void Update(Subscribe t)
        {
            _subscribeDAL.Update(t);
        }
    }
}

