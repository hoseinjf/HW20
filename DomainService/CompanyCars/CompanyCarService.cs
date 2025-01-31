using AppDomainCore.CompanyCars.Conteract;
using AppDomainCore.CompanyCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.CompanyCars
{
    public class CompanyCarService : ICompanyCarService
    {
        private readonly ICompanyCarRepository _companyCarRepository;
        public CompanyCarService(ICompanyCarRepository companyCarRepository)
        {
            _companyCarRepository = companyCarRepository;
        }

        public CompanyCar Add(CompanyCar companyCar)
        {
            return _companyCarRepository.Add(companyCar);
        }

        public bool Delete(int id)
        {
            return _companyCarRepository.Delete(id);
        }

        public CompanyCar Get(int id)
        {
            return _companyCarRepository.Get(id);
        }

        public List<CompanyCar> GetAll()
        {
            return _companyCarRepository.GetAll();
        }

        public CompanyCar Update(CompanyCar companyCar)
        {
            return _companyCarRepository.Update(companyCar);
        }
    }
}
