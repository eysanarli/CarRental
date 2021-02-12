using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IResult Add(Car car)
        {
            if (_carDal.GetAll(x => x.BrandId != default(int)).Count(x=>x.BrandId == car.BrandId) > 0)
            {
                return new ErrorResult(Messages.BrandIdExist);    
            }
 
            if (checkCarDescriptionValue(car) == true && checkCarDailyPriceValue(car) == true)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
                
            }
            else if (!checkCarDescriptionValue(car))
                return new ErrorResult(Messages.CarDescriptionInvalid);
            {

                if (!checkCarDailyPriceValue(car))
                {
                    return new ErrorResult(Messages.CarNameInvalid);
                }
                    return new ErrorResult(Messages.CarDailyPriceInvalid);
            } 
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

                return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarList);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<Car>GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id));
        }

        public IDataResult<List<Car>>GetByModelYear(int year)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ModelYear == year));
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            else
            {
                return new ErrorResult(Messages.CarUpdatedInvalid);
            }
        }
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}
