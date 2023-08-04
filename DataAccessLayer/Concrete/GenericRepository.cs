using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.HotelContext;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T>: IGenericDal<T> where T:class
    {
        private readonly HotelContext.Context _context;

        public GenericRepository(HotelContext.Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}

