
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
