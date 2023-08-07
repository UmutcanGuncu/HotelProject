using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IAppUserService:IGenericService<AppUser>
	{
		public List<AppUser> UserListWithLocation();
	}
}

