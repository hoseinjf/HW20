﻿using AppDomainCore.Cars.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.HW20.Cars.Contract._1_Repository
{
    public interface ICarRepository
    {
        public Car Add(Car car);
        public Car Get(int carId);
        public List<Car> GetAll();
    }
}
