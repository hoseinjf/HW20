using AppDomainCore.HW20.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.HW20.Cars.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Pluk { get; set; }
        public DateTime CreateYear { get; set; }
        public User User { get; set; }

    }
}
