using AppDomainCore.HW20.Users.Contract._2_Service;
using AppDomainCore.HW20.Users.Contract._3_AppService;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Users
{
    public class UserAppService:IUserAppService
    {
        private readonly IUserService _userService;
        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public User Add(User user)
        {
            throw new NotImplementedException();
        }

        public User Get(int UseId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
