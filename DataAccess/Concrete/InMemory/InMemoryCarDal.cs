using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //Simulation of databeses which comes from Oracle,Sql Server,Postgres,MongoDb
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=230694, ColorId=124554, ModelYear=1994, DailyPrice=165.000, Description="RANGE ROVER SECOND GENERATION"},
                new Car{Id=2, BrandId=211292, ColorId=172355, ModelYear=1992, DailyPrice=140.000, Description="BMW 3 SERIES HATCHBACK"},

                new Car{Id=3, BrandId=100616, ColorId=542367, ModelYear=2016, DailyPrice=1000, Description="ALFA ROMEO GIULIETTA"},

                new Car{Id=3, BrandId=100616, ColorId=542367, ModelYear=2016, DailyPrice=1000, Description="ALFA ROMEO GİULİETTA"},

                new Car{Id=4, BrandId=250816, ColorId=127535, ModelYear=2016, DailyPrice=750, Description="MERCEDES CLA 180d AMG"},
                new Car{Id=5, BrandId=300320, ColorId=254962, ModelYear=2020, DailyPrice=900, Description="AUDI Q2"}

            };
        }
        public void Add(Car car)
        {

            if (_cars.Count(c => c.Id == car.Id) == 0)
                _cars.Add(car);

            _cars.Add(car);

        }

        public void Delete(Car car)
        {

            Car CarToDelete = _cars.FirstOrDefault(Car => Car.Id == Car.Id);
            if (CarToDelete != null)
             _cars.Remove(CarToDelete);

        }

        public List<Car> GetAll()
        {

            return _cars;
    
        }

        public List<Car> GetAllByCategory(int categoryId)
        {

            return _cars.Where(c => c.Id == categoryId).ToList();

            throw new NotImplementedException();

        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(Car => Car.Id == car.Id);

            if (CarToUpdate == null) return;

            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;



        }
        

    }
}
