using Business.Concrete;
using Business.Constants;
using ConsoleTables;
using Core.Entities.Concrete;
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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

            Console.Clear();
            Designer.PrintLine();
            Designer.PrintRow("Car ID", "Brand Name", "Color Name", "Model Year", "Daily Price", "Description");
            Designer.PrintLine();

            foreach (var car in carManager.GetAll().Data)
            {
                Designer.PrintRow(car.CarId.ToString(), brandManager.GetById(car.BrandId).Data.BrandName, colorManager.GetById(car.ColorId).Data.ColorName, car.ModelYear.ToString(), car.DailyPrice.ToString(), car.Descriptions);
            }

            Designer.PrintLine();

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Günlük Kiralama Ücreti  " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            brandManager.Add(new Brand { BrandName = "HONDA CHR" });
            var newCar = new Car { BrandId = 6, ColorId = 3, DailyPrice = 300, ModelYear = 2021, Descriptions = "Otomatik Dizel" };
            carManager.Add(newCar);
            Console.WriteLine(Environment.NewLine + "Yeni Araba Eklendi" + Environment.NewLine);

            Designer.PrintRow(newCar.CarId.ToString(), brandManager.GetById(newCar.BrandId).Data.BrandName, colorManager.GetById(newCar.ColorId).Data.ColorName, newCar.ModelYear.ToString(), newCar.DailyPrice.ToString(), newCar.Descriptions);
            Designer.PrintLine();

            //userManager.Add(new User { FirstName = "Onur", LastName = "Y", Email = "o", Password = "1" });
            //userManager.Add(new User { FirstName = "Eyşan", LastName = "Y", Email = "o", Password = "1" });

            customerManager.Add(new Customer { CompanyName = "ECONTECH", UserId = 1 });
            var newCustomer1 = new Customer { CompanyName = "Posec Portfolio", UserId = 2 };
            Console.WriteLine(customerManager.Add(newCustomer1).Message);

            var IDataResult = customerManager.GetAll();


            Console.WriteLine("-- Sistemdeki kayıtlı müşteriler --");
            Designer.PrintLine();
            Designer.PrintRow("Müşteri Numarası", "Kullanıcı ID", "Şirket Adı");
            Designer.PrintLine();

            foreach (var customer in IDataResult.Data)
            {
                Designer.PrintRow(customer.Id.ToString(), customer.UserId.ToString(), customer.CompanyName);
                Designer.PrintLine();
            }

            Console.ReadKey();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.Id + " / " + rental.RentDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

    }
}



