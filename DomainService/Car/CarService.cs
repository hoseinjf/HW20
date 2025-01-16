using AppDomainCore.HW20.Cars.Contract._1_Repository;
using AppDomainCore.HW20.Cars.Contract._2_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Car
{
    public class CarService:ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public AppDomainCore.Cars.Entity.Car Add(AppDomainCore.Cars.Entity.Car car)
        {
            throw new NotImplementedException();
        }

        public AppDomainCore.Cars.Entity.Car Get(int carId)
        {
            throw new NotImplementedException();
        }

        public List<AppDomainCore.Cars.Entity.Car> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
