using AppDomainCore.OldCars.Contract._1_Repository;
using AppDomainCore.OldCars.Contract._2_Service;
using AppDomainCore.OldCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.OldCars
{
    public class OldCarService:IOldCarService
    {
        private readonly IOldCarRepository _repository;
        public OldCarService(IOldCarRepository carRepository)
        {
            _repository = carRepository;
        }

        public OldCar Add(OldCar car)
        {
            _repository.Add(car);
            return car;
        }

        public OldCar Get(int carId)
        {
            return _repository.Get(carId);
        }

        public List<OldCar> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
