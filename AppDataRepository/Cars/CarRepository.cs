﻿using AppDataRepository.Db;
using AppDomainCore.Cars.Entity;
using AppDomainCore.HW20.Cars.Contract._1_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Cars
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _db;
        public CarRepository(AppDbContext appDb)
        {
            _db = appDb;
        }
        public Car Add(Car car)
        {
            _db.Cars.Add(car);
            _db.SaveChanges();
            return car;
        }

        public Car Get(int carId)
        {
            var car = _db.Cars.FirstOrDefault(x => x.Id == carId);
            if (car == null)
            {
                throw new Exception("car is valid !!!");
            }
            return car;
        }

        public List<Car> GetAll()
        {
            return _db.Cars.ToList();
        }
        public bool Check(string pluk)
        {
            var car =_db.Cars.FirstOrDefault(x => x.Pluk==pluk && x.SetDate>DateTime.Now.AddYears(-1));
            if (car ==null) 
            {
                return true;
            }
            else
            {
                throw new Exception("خودرو شما در یک سال گذشته یکبار درخواست معاینه داشته است");
                //return false;
            }
        }
    }
}
