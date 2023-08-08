using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class EFRoomDal : GenericRepository<Room>, IRoomDal
    {
        private readonly Context _context;
        public EFRoomDal(Context context) : base(context)
        {
            _context = context;
        }

        public int RoomCount()
        {
            var value = _context.Rooms.Count();
            return value;
        }
    }
}

