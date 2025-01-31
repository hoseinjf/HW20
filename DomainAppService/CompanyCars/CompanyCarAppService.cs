using AppDomainCore.CompanyCars.Conteract;
using AppDomainCore.CompanyCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.CompanyCars
{
    public class CompanyCarAppService : ICompanyCarAppService
    {
        private readonly ICompanyCarService _companyCarService;
        public CompanyCarAppService(ICompanyCarService companyCarService)
        {
            _companyCarService = companyCarService;
        }

        public CompanyCar Add(CompanyCar companyCar)
        {
            return _companyCarService.Add(companyCar);
        }

        public bool Delete(int id)
        {
            return _companyCarService.Delete(id);
        }

        public CompanyCar Get(int id)
        {
            return (_companyCarService.Get(id));
        }

        public List<CompanyCar> GetAll()
        {
            return _companyCarService.GetAll();
        }

        public CompanyCar Update(CompanyCar companyCar)
        {
            return _companyCarService.Update(companyCar);
        }
    }
}
