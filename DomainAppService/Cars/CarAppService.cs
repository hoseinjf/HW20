
using AppDomainCore.Cars.Entity;
using AppDomainCore.HW20.Cars.Contract._2_Service;
using AppDomainCore.HW20.Cars.Contract._3_AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Cars
{
    public class CarAppService:ICardAppService
    {
        private readonly ICarService _cardService;
        public CarAppService(ICarService carService)
        {
            _cardService = carService;
        }

        public Car Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Car Get(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
