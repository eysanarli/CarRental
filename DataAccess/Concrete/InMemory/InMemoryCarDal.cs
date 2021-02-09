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
        //list<car> _cars;
        //public ınmemorycardal()
        //{
        //    //simulation of databeses which comes from oracle,sql server,postgres,mongodb
        //    _cars = new list<car>
        //    {
        //        new car{carıd=1, brandıd=1, colorıd=1, modelyear=1994, dailyprice= 800, description="manuel dizel"},
        //        new car{carıd=2, brandıd=2, colorıd=2, modelyear=1992, dailyprice= 600, description="manuel benzin"},
        //        new car{carıd=3, brandıd=3, colorıd=3, modelyear=2016, dailyprice= 950, description="otomatik dizel"},
        //        new car{carıd=4, brandıd=4, colorıd=2, modelyear=2016, dailyprice=1.250, description="otomatik dizel"},
        //        new car{carıd=5, brandıd=5, colorıd=5, modelyear=2020, dailyprice=3.000, description="otomatik benzin"}

        //    };
        //}
        //public void add(car car)
        //{

        //    if (_cars.count(c => c.carıd == car.carıd) == 0)
        //        _cars.add(car);

        //    _cars.add(car);

        //}

        //public void delete(car car)
        //{

        //    car cartodelete = _cars.firstordefault(car => car.carıd == car.carıd);
        //    if (cartodelete != null)
        //        _cars.remove(cartodelete);

        //}

        //public car get(expression<func<car, bool>> filter)
        //{
        //    throw new notımplementedexception();
        //}

        //public list<car> getall()
        //{

        //    return _cars;

        //}

        //public list<car> getall(expression<func<car, bool>> filter = null)
        //{
        //    throw new notımplementedexception();
        //}

        //public list<car> getallbycategory(int categoryıd)
        //{

        //    return _cars.where(c => c.carıd == categoryıd).tolist();

        //    throw new notımplementedexception();

        //}

        //public void update(car car)
        //{
        //    car cartoupdate = _cars.singleordefault(car => car.carıd == car.carıd);

        //    if (cartoupdate == null) return;

        //    cartoupdate.brandıd = car.brandıd;
        //    cartoupdate.colorıd = car.colorıd;
        //    cartoupdate.dailyprice = car.dailyprice;
        //    cartoupdate.modelyear = car.modelyear;
        //    cartoupdate.description = car.description;

        //}


    }
}
