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
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
        }

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.Clear();
            PrintLine();
            PrintRow("Car ID", "Brand Name", "Color Name", "Model Year", "Daily Price", "Description");
            PrintLine();

            foreach (var car in carManager.GetAll())
            {
                PrintRow(car.CarId.ToString(), brandManager.GetById(car.BrandId).BrandName, colorManager.GetById(car.ColorId).ColorName, car.ModelYear.ToString(), car.DailyPrice.ToString(), car.Descriptions);
            }

            PrintLine();

            //Console.WriteLine("Color id 2 olanları listele");
            //int index = 0;
            //foreach (var car in carManager.GetAllByColorId(2))
            //{
            //    Console.WriteLine(" Car ID " + car.CarId + " Color ID " + car.ColorId + " " + "Brand Name " + brandManager.GetById(index).BrandName + " Description " + car.Descriptions);
            //    index++;
            //}
            brandManager.Add(new Brand { BrandName = "HONDA CHR" });
            var newCar = new Car { BrandId = 6, ColorId = 3, DailyPrice = 300, ModelYear = 2021, Descriptions = "Otomatik Dizel" };
            carManager.Add(newCar);
            Console.WriteLine();
            Console.WriteLine("Yeni Araba Eklendi");
            Console.WriteLine();

            PrintRow(newCar.CarId.ToString(), brandManager.GetById(newCar.BrandId).BrandName, colorManager.GetById(newCar.ColorId).ColorName, newCar.ModelYear.ToString(), newCar.DailyPrice.ToString(), newCar.Descriptions);
            PrintLine();

            Console.ReadKey();
        }

        static int tableWidth = 130;

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}


