using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void Delete(AboutUs t)
        {
            _aboutUsDal.Delete(t);
        }

        public AboutUs GetById(Guid id)
        {
            return _aboutUsDal.GetById(id);
        }

        public List<AboutUs> GetList()
        {
            return _aboutUsDal.GetList();
        }

        public void Insert(AboutUs t)
        {
            _aboutUsDal.Insert(t);
        }

        public void Update(AboutUs t)
        {
            _aboutUsDal.Update(t);
        }
    }
}

