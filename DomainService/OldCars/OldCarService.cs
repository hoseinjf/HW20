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
            throw new NotImplementedException();
        }

        public OldCar Get(int carId)
        {
            throw new NotImplementedException();
        }

        public List<OldCar> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
