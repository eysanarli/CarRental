using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        private bool checkCarDescriptionValue(Car car)
        {
            bool checkValue = true;

            if (car.Descriptions.Length <= 2)
                checkValue = false;

            return checkValue;
        }

        private bool checkCarDailyPriceValue(Car car)
        {
            bool checkValue = true;

            if (car.DailyPrice == 0)
                checkValue = false;

            return checkValue;
        }
        public void Add(Car car)
        {
            if (checkCarDescriptionValue(car) == true & checkCarDailyPriceValue(car) == true)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi.");
            }
            else if (!checkCarDescriptionValue(car))
            {
                if (!checkCarDailyPriceValue(car))
                {
                    Console.WriteLine($"Araba ekleme işleminiz başarısız oldu. --> Günlük fiyat kısmını 0'dan büyük olmak üzere giriniz. Girdiğiniz değer : {car.DailyPrice}");
                }
                    Console.WriteLine("Araba ekleme işleminiz başarısız oldu. --> Araba isminiz minimum 2 karakter olmak üzere giriniz");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba başarıyla silindi.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetByModelYear(int year)
        {
            return _carDal.GetAll(c => c.ModelYear == year);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Araba başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            }
        }
    }
}
