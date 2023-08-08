using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IRoomService:IGenericService<Room>
	{
		public int RoomCount();
	}
}

