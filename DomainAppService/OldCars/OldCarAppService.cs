using AppDomainCore.OldCars.Contract._2_Service;
using AppDomainCore.OldCars.Contract._3_AppService;
using AppDomainCore.OldCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.OldCars
{
    public class OldCarAppService:IOldCarAppService
    {
        private readonly IOldCarService _Service;
        public OldCarAppService(IOldCarService oldCar)
        {
            _Service = oldCar;
        }

        public OldCar Add(OldCar car)
        {
            _Service.Add(car);
            return car;
        }

        public OldCar Get(int carId)
        {
           return _Service.Get(carId);
        }

        public List<OldCar> GetAll()
        {
           return _Service.GetAll();
        }
    }
}
