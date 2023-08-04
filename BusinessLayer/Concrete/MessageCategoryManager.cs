using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void Delete(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public MessageCategory GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<MessageCategory> GetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void Insert(MessageCategory t)
        {
            _messageCategoryDal.Insert(t);
        }

        public void Update(MessageCategory t)
        {
            throw new NotImplementedException();
        }
    }
}

