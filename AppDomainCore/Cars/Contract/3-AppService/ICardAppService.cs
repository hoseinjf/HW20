using AppDomainCore.Cars.Entity;
using AppDomainCore.OldCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.HW20.Cars.Contract._3_AppService
{
    public interface ICardAppService
    {
        public Car Add(Car car, OldCar? oldCars);
        public Car Get(int carId);
        public List<Car> GetAll();
        public bool Check(string pluk);
    }
}
