using AppDomainCore.Cars.Entity;
using AppDomainCore.OldCars.Entity;
using AppDomainCore.Users.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Users.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public List<Car>? Cars { get; set; }
        public List<OldCar>? OldCars { get; set; }
        public RoleEnum Role { get; set; } = RoleEnum.User;

    }
}
