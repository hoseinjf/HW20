using AppDomainCore.Cars.Entity;
using AppDomainCore.Cars.Enum;
using AppDomainCore.HW20.Cars.Contract._3_AppService;
using AppDomainCore.HW20.Users.Contract._3_AppService;
using AppDomainCore.OldCars.Entity;
using AppDomainCore.Users.Entity;
using Microsoft.AspNetCore.Mvc;

namespace HW20.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserAppService _userAppService;
        private readonly ICardAppService _cardAppService;
        public UserController(IUserAppService userApp,ICardAppService cardAppService)
        {
            _userAppService = userApp;
            _cardAppService = cardAppService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Phone,string NationalCode, StatusEnum statusEnum )
        {

            try
            {
                var user = _userAppService.GetByAdmin(Phone, NationalCode);
                var log = _userAppService.Login(user.UserId, user);
                if (log != null)
                {
                    var all = _cardAppService.GetAll();
                    ViewBag.status = all;

                    return View("Index1", all);
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                TempData["Message"] = ex.Message;
                TempData["AlertType"] = "danger";
                return View("Index");
            }
        }





        public IActionResult SetStatusOk(int Id)
        {
            var status = _cardAppService.CehngStatusOk(Id);
            var all = _cardAppService.GetAll();
            ViewBag.status = all;

            return View("Index1", all);
        }
        public IActionResult SetStatusCancel(int Id)
        {
            var status = _cardAppService.CehngStatusCancel(Id);
            var all = _cardAppService.GetAll();
            ViewBag.status = all;

            return View("Index1", all);
        }

    }
}
