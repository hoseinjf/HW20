using AppDomainCore.CompanyCars.Conteract;
using AppDomainCore.CompanyCars.Entity;
using AppDomainCore.Configs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW20API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyCars : ControllerBase
    {
        private readonly ICompanyCarAppService _companyCarAppService;
        private readonly Limits _limits;

        public CompanyCars(ICompanyCarAppService companyCarAppService, Limits limits)
        {
            _limits = limits;
            _companyCarAppService  = companyCarAppService;
        }
        [HttpGet]
        public List<CompanyCar> GetAll([FromHeader]string apikey)
        {
            if(apikey== _limits.ApiKey)
            {
                return _companyCarAppService.GetAll();
                
            }
            return new List<CompanyCar>();
        }
        [HttpPost("get")]
        public CompanyCar Get(int id,[FromHeader] string apikey)
        {
            if (apikey == _limits.ApiKey)
            {
                return _companyCarAppService.Get(id);

            }
            return null;
        }

        [HttpPost("added")]
        public CompanyCar AddCar(CompanyCar companyCar, [FromHeader] string apikey)
        {
            if (apikey == _limits.ApiKey)
            {
                return _companyCarAppService.Add(companyCar);

            }
            throw new Exception("aaaaaaaaaaaaaaaaaaaaaa");
        }


        [HttpPost("update")]
        public CompanyCar UpdateCar(CompanyCar companyCar, [FromHeader] string apikey)
        {

            if (apikey == _limits.ApiKey)
            {
                return _companyCarAppService.Update(companyCar);

            }
            return null;
        }

        [HttpPost("delete")]
        public bool DeleteCar(int id, [FromHeader] string apikey)
        {
            if (apikey == _limits.ApiKey)
            {
                return _companyCarAppService.Delete(id);

            }
            return false;
        }


    }
}
