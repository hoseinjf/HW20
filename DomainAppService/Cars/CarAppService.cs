
using AppDomainCore.Cars.Entity;
using AppDomainCore.Cars.Enum;
using AppDomainCore.Configs;
using AppDomainCore.HW20.Cars.Contract._2_Service;
using AppDomainCore.HW20.Cars.Contract._3_AppService;
using AppDomainCore.OldCars.Contract._2_Service;
using AppDomainCore.OldCars.Entity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Cars
{
    public class CarAppService : ICardAppService
    {
        private readonly ICarService _cardService;
        private readonly IOldCarService _ldCarService;
        private readonly Limits _limits;
        public CarAppService(ICarService carService, IOldCarService oldCarService, Limits limits)
        {
            _cardService = carService;
            _ldCarService = oldCarService;
            _limits = limits;
        }

        public Car Add(Car car, OldCar? oldCars)
        {
            int zoj = _limits.Zoj;
            int fard = _limits.Fard;
            var pl = _cardService.Check(car.Pluk);
            if (pl == true)
            {
                if (car.CreateYear > DateTime.Now.AddYears(-5))
                {
                    if (WeekEnum.Saturday.ToString() == car.SetDate.Day.ToString() ||
                    WeekEnum.Monday.ToString() == car.SetDate.DayOfWeek.ToString() ||
                    WeekEnum.Wednesday.ToString() == car.SetDate.DayOfWeek.ToString())
                    {
                        if (car.DeyCount <= zoj)
                        {
                            if (car.Company == CompanyEnum.irankhidro)
                            {
                                car.DeyCount=car.DeyCount+1;
                                return _cardService.Add(car);
                            }
                            else
                            {
                                throw new Exception("Your vehicle will not be accepted on this day");
                            }
                        }
                        else
                        {
                            throw new Exception("محدودیت پذیرش امروز به پایان رسیده است");
                        }

                    }
                    else if (WeekEnum.Sunday.ToString() == car.SetDate.DayOfWeek.ToString() ||
                        WeekEnum.Tuesday.ToString() == car.SetDate.DayOfWeek.ToString() ||
                        WeekEnum.Thursday.ToString() == car.SetDate.DayOfWeek.ToString())
                    {
                        if (car.DeyCount <= zoj)
                        {
                            if (car.Company == CompanyEnum.saipa)
                            {
                                return _cardService.Add(car);

                            }
                            else
                            {
                                throw new Exception("Your vehicle will not be accepted on this day");
                            }
                        }
                        else
                        {
                            throw new Exception("محدودیت پذیرش امروز به پایان رسیده است");
                        }
                    }
                    else if (WeekEnum.Friday.ToString() == car.SetDate.DayOfWeek.ToString())
                    {
                        throw new Exception("We do not accept applications on Fridays.");
                    }
                    else
                    {
                        throw new Exception("Your vehicle will not be accepted on this day.");
                    }
                }
                else
                {
                    oldCars.Id = car.Id;
                    oldCars.Name = car.Name;
                    oldCars.User = car.User;
                    oldCars.Company = car.Company;
                    oldCars.Pluk = car.Pluk;
                    oldCars.SetDate = car.SetDate;
                    oldCars.CreateYear = car.CreateYear;
                    _ldCarService.Add(oldCars);
                    throw new Exception("Your car is more than 5 years old.");
                }
            }
            else
            {
                throw new Exception("این خودو در یکسال گذشته درخواست معاینه ثبت شده دارد");
            }
        }

        public Car Get(int carId)
        {
            return _cardService.Get(carId);
        }

        public List<Car> GetAll()
        {
            return _cardService.GetAll();
        }
        public bool Check(string pluk)
        {
            return _cardService.Check(pluk);
        }
        public Car CehngStatusCancel(int id)
        {
            return _cardService.CehngStatusCancel(id);
        }
        public Car CehngStatusOk(int id)
        {
            return _cardService.CehngStatusOk(id);
        }


        //odl add
        /*
         * 
         *         public Car Add(Car car, OldCar? oldCars)
        {
            int zoj = int.Parse(_configuration.GetSection("Limits:zoj").Value);
            int fard = int.Parse(_configuration.GetSection("Limits:fard").Value);

            if (car.CreateYear > DateTime.Now.AddYears(-5))
            {
                if (Convert.ToInt32(WeekEnum.Saturday) == Convert.ToInt32(car.SetDate.Day) ||
                Convert.ToInt32(WeekEnum.Monday) == Convert.ToInt32(car.SetDate.Day) ||
                Convert.ToInt32(WeekEnum.Wednesday) == Convert.ToInt32(car.SetDate.Day))
                {
                    if (car.DeyCount < zoj)
                    {
                        car.DeyCount++;
                        if (car.DeyCount == 1)
                        {
                            car.DeyTime = DateTime.Now.AddDays(1);
                            if (car.Company == CompanyEnum.irankhidro)
                            {
                                return _cardService.Add(car);
                            }
                            else
                            {
                                throw new Exception("Your vehicle will not be accepted on this day");
                            }
                        }
                        if (car.Company == CompanyEnum.irankhidro)
                        {
                            return _cardService.Add(car);
                        }
                        else
                        {
                            throw new Exception("Your vehicle will not be accepted on this day");
                        }
                    }
                    if (car.DeyCount == zoj && car.DeyTime > DateTime.Now)
                    {
                        car.DeyCount = zoj;
                        throw new Exception("ظرفیت پذیرش امروز تمام شد");
                    }
                    if (car.DeyCount == zoj && car.DeyTime <= DateTime.Now)
                    {
                        car.DeyCount = 0;
                        if (car.Company == CompanyEnum.irankhidro)
                        {
                            return _cardService.Add(car);
                        }
                        else
                        {
                            throw new Exception("Your vehicle will not be accepted on this day");
                        }
                    }
                    else
                    {
                        if (car.Company == CompanyEnum.irankhidro)
                        {
                            return _cardService.Add(car);
                        }
                        else
                        {
                            throw new Exception("Your vehicle will not be accepted on this day");
                        }
                    }
                }
                else if (Convert.ToInt32(WeekEnum.Sunday) == Convert.ToInt32(car.SetDate.Day) ||
                    Convert.ToInt32(WeekEnum.Tuesday) == Convert.ToInt32(car.SetDate.Day) ||
                    Convert.ToInt32(WeekEnum.Thursday) == Convert.ToInt32(car.SetDate.Day))
                {
                    if (car.DeyCount < fard)
                    {
                        car.DeyCount++;
                        if (car.DeyCount == 1)
                        {
                            car.DeyTime = DateTime.Now.AddDays(1);
                            if (car.Company == CompanyEnum.irankhidro)
                            {
                                return _cardService.Add(car);
                            }
                            else
                            {
                                throw new Exception("Your vehicle will not be accepted on this day");
                            }
                        }
                        if (car.Company == CompanyEnum.saipa)
                        {
                            return _cardService.Add(car);

                        }
                        else
                        {
                            throw new Exception("Your vehicle will not be accepted on this day");
                        }
                    }
                    if (car.DeyCount == fard && car.DeyTime > DateTime.Now)
                    {
                        car.DeyCount = fard;
                        throw new Exception("ظرفیت پذیرش امروز تمام شد");
                    }
                    if (car.DeyCount == fard && car.DeyTime <= DateTime.Now)
                    {
                        car.DeyCount = 0;
                        if (car.Company == CompanyEnum.irankhidro)
                        {
                            return _cardService.Add(car);
                        }
                        else
                        {
                            throw new Exception("Your vehicle will not be accepted on this day");
                        }
                    }
                    else
                    {
                        if (car.Company == CompanyEnum.irankhidro)
                        {
                            return _cardService.Add(car);
                        }
                        else
                        {
                            throw new Exception("Your vehicle will not be accepted on this day");
                        }
                    }
                }
                else if (Convert.ToInt32(WeekEnum.Friday) == Convert.ToInt32(car.SetDate.Day))
                {
                    throw new Exception("We do not accept applications on Fridays.");
                }
                else
                {
                    throw new Exception("Your vehicle will not be accepted on this day.");
                }
            }
            else
            {
                oldCars.Id = car.Id;
                oldCars.Name = car.Name;
                oldCars.User = car.User;
                oldCars.Company = car.Company;
                oldCars.Pluk = car.Pluk;
                oldCars.SetDate = car.SetDate;
                oldCars.CreateYear = car.CreateYear;
                _ldCarService.Add(oldCars);
                throw new Exception("Your car is more than 5 years old.");
            }

        }
         * 
         */

        //up cline GTP
        /*
         public Car Add(Car car, OldCar? oldCars)
{
    int zoj = int.Parse(_configuration.GetSection("Limits:zoj").Value);
    int fard = int.Parse(_configuration.GetSection("Limits:fard").Value);

    // بررسی سن خودرو
    if (car.CreateYear <= DateTime.Now.AddYears(-5))
    {
        HandleOldCar(car, oldCars);
        throw new Exception("Your car is more than 5 years old.");
    }

    // بررسی روز هفته
    DayOfWeek day = car.SetDate.DayOfWeek;
    bool isZojDay = day == DayOfWeek.Saturday || day == DayOfWeek.Monday || day == DayOfWeek.Wednesday;
    bool isFardDay = day == DayOfWeek.Sunday || day == DayOfWeek.Tuesday || day == DayOfWeek.Thursday;

    if (day == DayOfWeek.Friday)
    {
        throw new Exception("We do not accept applications on Fridays.");
    }

    if (isZojDay)
    {
        return ProcessCar(car, zoj, CompanyEnum.irankhidro);
    }

    if (isFardDay)
    {
        return ProcessCar(car, fard, CompanyEnum.saipa);
    }

    throw new Exception("Your vehicle will not be accepted on this day.");
}

// متد برای پردازش خودروهای جدید
private Car ProcessCar(Car car, int limit, CompanyEnum requiredCompany)
{
    if (car.DeyCount < limit)
    {
        car.DeyCount++;
        if (car.DeyCount == 1)
        {
            car.DeyTime = DateTime.Now.AddDays(1);
        }

        if (car.Company == requiredCompany)
        {
            return _cardService.Add(car);
        }
        else
        {
            throw new Exception("Your vehicle will not be accepted on this day");
        }
    }

    if (car.DeyCount == limit)
    {
        if (car.DeyTime > DateTime.Now)
        {
            throw new Exception("ظرفیت پذیرش امروز تمام شد");
        }

        car.DeyCount = 0;
        if (car.Company == requiredCompany)
        {
            return _cardService.Add(car);
        }
        else
        {
            throw new Exception("Your vehicle will not be accepted on this day");
        }
    }

    throw new Exception("Unhandled condition in ProcessCar method.");
}

// متد برای مدیریت خودروهای قدیمی
private void HandleOldCar(Car car, OldCar? oldCars)
{
    if (oldCars == null) throw new ArgumentNullException(nameof(oldCars));

    oldCars.Id = car.Id;
    oldCars.Name = car.Name;
    oldCars.User = car.User;
    oldCars.Company = car.Company;
    oldCars.Pluk = car.Pluk;
    oldCars.SetDate = car.SetDate;
    oldCars.CreateYear = car.CreateYear;

    _ldCarService.Add(oldCars);
}

         */






    }
}
