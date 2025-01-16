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
