using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.HW20.Users.Contract._1_Repository
{
    public interface IUserRepository
    {
        public User Add(User user);
        public User Get(int UseId);
        public List<User> GetAll();
    }
}
