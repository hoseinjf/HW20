using AppDomainCore.HW20.Users.Contract._1_Repository;
using AppDomainCore.HW20.Users.Contract._2_Service;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Add(User user)
        {
            _userRepository.Add(user);
            return user;
        }

        public User Get(int UseId)
        {
            return _userRepository.Get(UseId);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User Login(int id, User user)
        {
            return _userRepository.Login(id, user);
        }

        public User GetByAdmin(string phone, string nationalCode)
        {
            return _userRepository.GetByAdmin(phone, nationalCode);
        }



    }
}
