using AppDomainCore.Cars.Enum;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.OldCars.Entity
{
    public class OldCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyEnum Company { get; set; }
        public string Pluk { get; set; }
        public DateTime CreateYear { get; set; }
        public User User { get; set; }
        public DateTime SetDate { get; set; } = DateTime.Now;
    }
}
