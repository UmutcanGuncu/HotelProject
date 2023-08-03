using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void Delete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage GetById(Guid id)
        {
            return _sendMessageDal.GetById(id);
        }

        public List<SendMessage> GetList()
        {
            return _sendMessageDal.GetList();
        }

        public void Insert(SendMessage t)
        {
            _sendMessageDal.Insert(t);
        }

        public void Update(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}

