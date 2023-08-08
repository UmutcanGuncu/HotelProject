using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        private readonly Context _context;
        public EfAppUserDal(Context context) : base(context)
        {
            _context = context;
        }

        public int AppUserCount()
        {
            var value =_context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithLocation()
        {
            return _context.Users.Include(x => x.WorkLocationId).ToList();
        }
    }
}

