using AppDomainCore.OldCars.Contract._1_Repository;
using AppDomainCore.OldCars.Contract._2_Service;
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
    }
}
