using System;
namespace BusinessLayer.Abstract
{
	public interface IGenericService<T> where T:class
	{
        List<T> GetList();
        void Delete(T t);
        void Update(T t);
        void Insert(T t);
        T GetById(int id);
    }
}

