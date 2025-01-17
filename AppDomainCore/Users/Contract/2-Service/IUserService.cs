using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.HW20.Users.Contract._2_Service
{
    public interface IUserService
    {
        public User Add(User user);
        public User Get(int UseId);
        public List<User> GetAll();
        public bool Login(User user);
    }
}
