using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CompanyCars.Entity
{
    public class CompanyCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public DateTime CreateYear { get; set; }
    }
}
