using AppDomainCore.HW20.Users.Contract._2_Service;
using AppDomainCore.HW20.Users.Contract._3_AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.User
{
    public class UserAppService:IUserAppService
    {
        private readonly IUserService _userService;
        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public AppDomainCore.Users.Entity.User Add(AppDomainCore.Users.Entity.User user)
        {
            throw new NotImplementedException();
        }

        public AppDomainCore.Users.Entity.User Get(int UseId)
        {
            throw new NotImplementedException();
        }

        public List<AppDomainCore.Users.Entity.User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
