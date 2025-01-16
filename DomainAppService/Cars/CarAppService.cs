
using AppDomainCore.Cars.Entity;
using AppDomainCore.Cars.Enum;
using AppDomainCore.HW20.Cars.Contract._2_Service;
using AppDomainCore.HW20.Cars.Contract._3_AppService;
using AppDomainCore.OldCars.Contract._2_Service;
using AppDomainCore.OldCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Cars
{
    public class CarAppService : ICardAppService
    {
        private readonly ICarService _cardService;
        private readonly IOldCarService _ldCarService;
        public CarAppService(ICarService carService,IOldCarService oldCarService)
        {
            _cardService = carService;
            _ldCarService = oldCarService;
        }

        public Car Add(Car car,OldCar? oldCars)
        {
            if (car.CreateYear<=DateTime.Now.AddSeconds(5))
            {
                if ((DayOfWeek)WeekEnum.Saturday == car.SetDate.DayOfWeek ||
                (DayOfWeek)WeekEnum.Monday == car.SetDate.DayOfWeek ||
                (DayOfWeek)WeekEnum.Wednesday == car.SetDate.DayOfWeek)
                {
                    if (car.Company == CompanyEnum.irankhidro)
                    {
                        return _cardService.Add(car);
                    }
                    else
                    {
                        throw new Exception("Your vehicle will not be accepted on this day");
                    }
                }
                else if ((DayOfWeek)WeekEnum.Sunday == car.SetDate.DayOfWeek ||
                    (DayOfWeek)WeekEnum.Tuesday == car.SetDate.DayOfWeek ||
                    (DayOfWeek)WeekEnum.Thursday == car.SetDate.DayOfWeek)
                {
                    if (car.Company == CompanyEnum.saipa)
                    {
                        return _cardService.Add(car);

                    }
                    else
                    {
                        throw new Exception("Your vehicle will not be accepted on this day");
                    }
                }
                else if ((DayOfWeek)WeekEnum.Friday == car.SetDate.DayOfWeek)
                {
                    throw new Exception("We do not accept applications on Fridays.");
                }
                else
                {
                    throw new Exception("The input given is not valid.");
                }
            }
            else
            {
                oldCars.Id = car.Id;
                oldCars.Name = car.Name;
                oldCars.User = car.User;
                oldCars.Company = car.Company;
                oldCars.Pluk = car.Pluk;
                oldCars.SetDate=car.SetDate;
                oldCars.CreateYear = car.CreateYear;
                _ldCarService.Add(oldCars);
                throw new Exception("Your car is more than 5 years old.");
            }

        }

        public Car Get(int carId)
        {
            return _cardService.Get(carId);
        }

        public List<Car> GetAll()
        {
            return _cardService.GetAll();
        }
    }
}
