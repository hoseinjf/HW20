using AppDomainCore.CompanyCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CompanyCars.Conteract
{
    public interface ICompanyCarRepository
    {
        public CompanyCar Add(CompanyCar companyCar);
        public CompanyCar Update(CompanyCar companyCar);
        public bool Delete(int id);
        public CompanyCar Get(int id);
        public List<CompanyCar> GetAll();

    }
}
