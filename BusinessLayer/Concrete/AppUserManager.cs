using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void Delete(AppUser t)
        {
            _appUserDal.Delete(t);
        }

        public AppUser GetById(Guid id)
        {
            return _appUserDal.GetById(id);
        }

        public List<AppUser> GetList()
        {
            return _appUserDal.GetList();
        }

        public void Insert(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void Update(AppUser t)
        {
            _appUserDal.Update(t);
        }

        public List<AppUser> UserListWithLocation()
        {
            return _appUserDal.UserListWithLocation();
        }
    }
}

