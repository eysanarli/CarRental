using Business.Concrete;
using ConsoleTables;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleUI
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Designer.ShowWindow(Designer.ThisConsole, 3);

            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.Clear();
            Designer.PrintLine();
            Designer.PrintRow("Car ID", "Brand Name", "Color Name", "Model Year", "Daily Price", "Description");
            Designer.PrintLine();

            foreach (var car in carManager.GetAll())
            {
                Designer.PrintRow(car.CarId.ToString(), brandManager.GetById(car.BrandId).BrandName, colorManager.GetById(car.ColorId).ColorName, car.ModelYear.ToString(), car.DailyPrice.ToString(), car.Descriptions);
            }

            Designer.PrintLine();


            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine( "Günlük Kiralama Ücreti  " + car.DailyPrice);
            }


            brandManager.Add(new Brand { BrandName = "HONDA CHR" });
            var newCar = new Car { BrandId = 6, ColorId = 3, DailyPrice = 300, ModelYear = 2021, Descriptions = "Otomatik Dizel" };
            carManager.Add(newCar);
            Console.WriteLine();
            Console.WriteLine("Yeni Araba Eklendi");
            Console.WriteLine();

            Designer.PrintRow(newCar.CarId.ToString(), brandManager.GetById(newCar.BrandId).BrandName, colorManager.GetById(newCar.ColorId).ColorName, newCar.ModelYear.ToString(), newCar.DailyPrice.ToString(), newCar.Descriptions);
            Designer.PrintLine();


            Console.ReadKey();


        }

    }
}

