using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories;
using IsTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Business.Concrete
{
    public class UserManager : IUserService
    {
        //private readonly IUserService _userService;
        private readonly EfUserRepositoryDal _userService;

        public UserManager(EfUserRepositoryDal userService)
        {
            _userService = userService;
        }

        //public UserManager(IUserService userService)
        //{
        //    _userService = userService;
        //}

        public void Add(User entity)
        {
           _userService.Add(entity);
        }

        public void Delete(User entity)
        {
            _userService.Delete(entity);

        }

        public List<User> GetAll()
        {
           return _userService.GetAll();

        }

        public User GetById(int id)
        {
            return _userService.GetById(id);

        }

        public void Update(User entity)
        {
            _userService.Update(entity);

        }
    }
}
