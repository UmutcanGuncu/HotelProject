﻿using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T>: IGenericDal<T> where T:class
    {
        private readonly HotelContext _context;

        public GenericRepository(HotelContext context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
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

