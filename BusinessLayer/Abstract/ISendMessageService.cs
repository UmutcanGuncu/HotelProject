using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ISendMessageService:IGenericService<SendMessage>
	{
        public int SendMessageCount();

    }
}

