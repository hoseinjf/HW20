using AppDomainCore.Cars.Entity;
using AppDomainCore.Cars.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.HW20.Cars.Contract._1_Repository
{
    public interface ICarRepository
    {
        public Car Add(Car car);
        public Car Get(int carId);
        public List<Car> GetAll();
        public bool Check(string pluk);
        public Car CehngStatusCancel(int id);
        public Car CehngStatusOk(int id);
        public bool SetCount(Car car, int z);
    }
}
