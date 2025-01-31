using AppDataRepository.Db;
using AppDomainCore.CompanyCars.Conteract;
using AppDomainCore.CompanyCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.CompanyCars
{
    public class CompanyCarRepository: ICompanyCarRepository
    {
        private readonly AppDbContext _dbContext;
        public CompanyCarRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public CompanyCar Add(CompanyCar companyCar)
        {
            if (companyCar != null) 
            {
                _dbContext.CompanyCars.Add(companyCar);
                _dbContext.SaveChanges();
                return companyCar;
                
            }
            throw new Exception("Car is null");
        }

        public bool Delete(int id)
        {
            var car = _dbContext.CompanyCars.FirstOrDefault(x => x.Id == id);
            if (car != null) 
            {
                _dbContext.CompanyCars.Remove(car);
                _dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        public CompanyCar Get(int id)
        {
            var car = _dbContext.CompanyCars.FirstOrDefault(x=> x.Id==id);
            if (car != null)
            {
                return car;
            }
            throw new Exception($"Could not find {id}");
        }

        public List<CompanyCar> GetAll()
        {
            return _dbContext.CompanyCars.ToList();
        }

        public CompanyCar Update(CompanyCar companyCar)
        {
            if (companyCar != null)
            {
                var car = Get(companyCar.Id);
  
                car.CreateYear=companyCar.CreateYear;
                car.Company=companyCar.Company;
                car.Name=companyCar.Name;
                _dbContext.CompanyCars.Update(car);
                _dbContext.SaveChanges();

                return car;
            }
            throw new Exception("id is null");
        }
    }
}
