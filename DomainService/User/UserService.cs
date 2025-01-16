using AppDomainCore.HW20.Users.Contract._1_Repository;
using AppDomainCore.HW20.Users.Contract._2_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.User
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
