using AppDomainCore.Cars.Enum;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Cars.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CompanyEnum Company { get; set; }
        public string Pluk { get; set; }
        public DateTime CreateYear { get; set; }
        public User User { get; set; }
        public DateTime SetDate { get; set; } = DateTime.Now;
        public int? DeyCount { get; set; } = 0;
        public DateTime? DeyTime { get; set; }
        public StatusEnum? Status { get; set; } = StatusEnum.Waiting;


    }
}
