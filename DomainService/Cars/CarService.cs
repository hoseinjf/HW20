using AppDomainCore.Cars.Entity;
using AppDomainCore.HW20.Cars.Contract._1_Repository;
using AppDomainCore.HW20.Cars.Contract._2_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Cars
{
    public class CarService:ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car Add(Car car)
        {
            _carRepository.Add(car);
            return car;
        }

        public Car Get(int carId)
        {
            return _carRepository.Get(carId);
        }

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public bool Check(string pluk)
        {
            return _carRepository.Check(pluk);
        }

    }
}
