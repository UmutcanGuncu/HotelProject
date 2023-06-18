using System;
namespace DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T:class
	{
		List<T> GetList();
		void Delete(T t);
		void Update(T t);
		void Insert(T t);
		T GetById(int id);
	}
}

