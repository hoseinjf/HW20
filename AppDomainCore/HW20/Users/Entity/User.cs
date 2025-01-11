using AppDomainCore.HW20.Cars.Entity;
using AppDomainCore.HW20.Users.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.HW20.Users.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public List<Car>? Cars { get; set; }
        public RoleEnum Role { get; set; } = RoleEnum.None;
        public DateTime SetDate { get; set; } = Convert.ToDateTime("2000/01/01");
    }
}
