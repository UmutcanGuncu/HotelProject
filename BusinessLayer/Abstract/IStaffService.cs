using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IStaffService:IGenericService<Staff>
	{
        public int GetStaffCount();
        public List<Staff> Last4Staff();
    }
}

