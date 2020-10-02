
using System;

using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using helloentity;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace helloentity
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _UserRepo;

        public UserService(IRepository<User> userRepo)
        {
            _UserRepo = userRepo;
        }
        public IEnumerable<User> GetAll()
        {
            return _UserRepo.GetAll();
        }
        public User GetById(int id, bool isActive = true)
        {
            return _UserRepo.Get(id, isActive);
        }
        public void Insert(User entity, bool saveChange = true)
        {

        }
        public void Update(User entity, bool saveChange = true)
        {

        }
        public void Delete(User entity, bool saveChange = true)
        {

        }

        public IEnumerable<User> Filter(Expression<Func<User, bool>> filter)
        {
            return _UserRepo.Filter(filter);
        }
    }
}