using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IAppUserDal:IGenericDal<AppUser>
	{
		public List<AppUser> UserListWithLocation();
		public int AppUserCount();
	}
}

