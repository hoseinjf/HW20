using AppDomainCore.HW20.Cars.Contract._2_Service;
using AppDomainCore.HW20.Cars.Contract._3_AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Car
{
    public class CarAppService:ICardAppService
    {
        private readonly ICarService _cardService;
        public CarAppService(ICarService carService)
        {
            _cardService = carService;
        }
    }
}
