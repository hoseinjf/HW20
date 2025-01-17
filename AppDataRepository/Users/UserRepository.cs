using AppDataRepository.Db;
using AppDomainCore.HW20.Users.Contract._1_Repository;
using AppDomainCore.Users.Entity;
using AppDomainCore.Users.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;
        public UserRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public User Add(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return user;
        }

        public User Get(int UseId)
        {
            var user = _db.Users.FirstOrDefault(x => x.UserId == UseId);
            if (user == null)
            {
                throw new Exception("User is valid !!!");
            }
            return user;
        }

        public User GetByAdmin(string phone,string nationalCode)
        {
            var user = _db.Users.FirstOrDefault(x => x.Phone == phone && x.NationalCode == nationalCode);
            if (user == null)
            {
                throw new Exception("User is valid !!!");
            }
            return user;
        }

        public List<User> GetAll()
        {
            return _db.Users.ToList();
        }
        public User Login(int id,User user)
        {
            user = Get(id);

            if (user.Role == RoleEnum.Admin)
            {
                return user;
            }
            else
            {
                throw new Exception("شما مجاز به ورود نیستید");
            }
        }
    }
}
