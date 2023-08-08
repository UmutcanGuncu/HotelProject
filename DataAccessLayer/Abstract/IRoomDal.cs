using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IRoomDal:IGenericDal<Room>
	{
        Room GetById(Guid id);
        public int RoomCount();

	}
}

