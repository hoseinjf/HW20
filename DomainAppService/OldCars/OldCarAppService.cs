using AppDomainCore.OldCars.Contract._2_Service;
using AppDomainCore.OldCars.Contract._3_AppService;
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
    }
}
