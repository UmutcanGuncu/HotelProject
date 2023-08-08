using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IStaffDAL:IGenericDal<Staff>
	{
		public int GetStaffCount();
		public List<Staff> Last4Staff();
	}
}

