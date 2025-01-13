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
    }
}
