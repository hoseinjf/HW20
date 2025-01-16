using AppDomainCore.OldCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.OldCars.Contract._3_AppService
{
    public interface IOldCarAppService
    {
        public OldCar Add(OldCar car);
        public OldCar Get(int carId);
        public List<OldCar> GetAll();
    }
}
