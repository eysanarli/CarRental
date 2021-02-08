using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class /*InMemoryCarDal : ICarDal*/
         public class InMemoryCarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    //Simulation of databeses which comes from Oracle,Sql Server,Postgres,MongoDb
        //    _cars = new List<Car>
        //    {
        //        new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=1994, DailyPrice= 800, Description="Manuel Dizel"},
        //        new Car{CarId=2, BrandId=2, ColorId=2, ModelYear=1992, DailyPrice= 600, Description="Manuel Benzin"},
        //        new Car{CarId=3, BrandId=3, ColorId=3, ModelYear=2016, DailyPrice= 950, Description="Otomatik Dizel"},
        //        new Car{CarId=4, BrandId=4, ColorId=2, ModelYear=2016, DailyPrice=1.250, Description="Otomatik Dizel"},
        //        new Car{CarId=5, BrandId=5, ColorId=5, ModelYear=2020, DailyPrice=3.000, Description="Otomatik Benzin"}

        //    };
        //}
        //public void Add(Car car)
        //{

        //    if (_cars.Count(c => c.CarId == car.CarId) == 0)
        //        _cars.Add(car);

        //    _cars.Add(car);

        //}

        //public void Delete(Car car)
        //{

        //    Car CarToDelete = _cars.FirstOrDefault(Car => Car.CarId == Car.CarId);
        //    if (CarToDelete != null)
        //     _cars.Remove(CarToDelete);

        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAll()
        //{

        //    return _cars;
    
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAllByCategory(int categoryId)
        //{

        //    return _cars.Where(c => c.CarId == categoryId).ToList();

        //    throw new NotImplementedException();

        //}

        //public void Update(Car car)
        //{
        //    Car CarToUpdate = _cars.SingleOrDefault(Car => Car.CarId == car.CarId);

        //    if (CarToUpdate == null) return;

        //    CarToUpdate.BrandId = car.BrandId;
        //    CarToUpdate.ColorId = car.ColorId;
        //    CarToUpdate.DailyPrice = car.DailyPrice;
        //    CarToUpdate.ModelYear = car.ModelYear;
        //    CarToUpdate.Description = car.Description;

        //}
        

    }
}
