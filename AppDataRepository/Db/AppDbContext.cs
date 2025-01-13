using AppDomainCore.Cars.Entity;
using AppDomainCore.OldCars.Entity;
using AppDomainCore.Users.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<OldCar> OldCars { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
