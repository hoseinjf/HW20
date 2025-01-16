using AppDomainCore.OldCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.OldCars.Contract._1_Repository
{
    public interface IOldCarRepository
    {
        public OldCar Add(OldCar car);
        public OldCar Get(int carId);
        public List<OldCar> GetAll();
    }
}
