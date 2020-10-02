
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;

namespace helloentity
{
    public interface IUserService
    { 
        IEnumerable<User> GetAll();
        User GetById(int id, bool isActive = true);
        void Insert(User entity, bool saveChange = true);
        void Update(User entity, bool saveChange = true);
        void Delete(User entity, bool saveChange = true);
        IEnumerable<User> Filter(Expression<Func<User, bool>> filter);
    }
}