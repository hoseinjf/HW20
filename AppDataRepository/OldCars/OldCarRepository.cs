using AppDataRepository.Db;
using AppDomainCore.OldCars.Contract._1_Repository;
using AppDomainCore.OldCars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.OldCars
{
    public class OldCarRepository : IOldCarRepository
    {
        private readonly AppDbContext appDbContext;
        public OldCarRepository(AppDbContext appDb)
        {
            appDbContext = appDb;
        }
        public OldCar Add(OldCar oldCar)
        {
            appDbContext.OldCars.Add(oldCar);
            appDbContext.SaveChanges();
            return oldCar;
        }

        public OldCar Get(int carId)
        {
            var oldCar = appDbContext.OldCars.FirstOrDefault(x => x.Id == carId);
            if (oldCar == null)
            {
                throw new Exception("car is valid !!!");
            }
            return oldCar;
        }

        public List<OldCar> GetAll()
        {
            return appDbContext.OldCars.ToList();
        }
    }
}
