using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace helloentity
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;

        public UserController(IUserService userService)
        {
            this._UserService = userService;
        }

        [HttpGet]
        public User Get()
        {
            return _UserService.GetAll().Include<User>(x => x.UserRoles.Select<UserRole>(p => p));
        }
    }
}
