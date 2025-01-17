using AppDomainCore.HW20.Cars.Contract._3_AppService;
using AppDomainCore.HW20.Users.Contract._3_AppService;
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
        public IActionResult Index(User user)
        {
            var log = _userAppService.Login(user);
            if (log==true)
            {
                var all = _cardAppService.GetAll();
                return View(all);
            }
            return RedirectToAction("Index","Home");
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
