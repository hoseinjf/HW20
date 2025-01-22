using AppDomainCore.Cars.Entity;
using AppDomainCore.Cars.Enum;
using AppDomainCore.CompanyCars.Entity;
using AppDomainCore.HW20.Cars.Contract._3_AppService;
using AppDomainCore.OldCars.Entity;
using AppDomainCore.Users.Entity;
using Microsoft.AspNetCore.Mvc;

namespace HW20.Controllers
{
    public class CarController : Controller
    {
        private readonly ICardAppService _cardAppService;
        public CarController(ICardAppService cardAppService)
        {
            _cardAppService = cardAppService;
        }
        public IActionResult Index(Car? car, OldCar? oldCar, User? user, CompanyEnum companyCar,int i = 0)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Car? car,OldCar? oldCar,User user, CompanyEnum companyCar)
        {
            car.Company = companyCar;
            car.User = user;
            oldCar.User = user;
            oldCar.Company = companyCar;

            try
            {

                var c = _cardAppService.Add(car, oldCar);
            }
            catch (Exception ex) 
            {
                TempData["Message"] = ex.Message;
                TempData["AlertType"] = "danger";
                return View("Index");
            }
            return View("Index1");
        }
    }
}
