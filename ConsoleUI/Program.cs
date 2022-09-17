using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CarAdd();
            //CarDelete();
            //CarUpdate();
            //BrandAdd();
            //BrandTest();
            //BrandDelete();
            //BrandUpdate();
            //ColorTest();
            //ColorAdd();
            //ColorDelete();
            //ColorUpdate();

        }

        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 7, ColorName = "Uranus" });
        }

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 6 });
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Purple" });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName + "/" + color.ColorId);
            }
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 3, BrandName = "Mercedes" });
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 1004 });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 2, CarName = "Accent", BrandId = 2, ColorId = 3 });
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Mercedes" });
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 3 });
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, CarName = "Audi", ColorId = 2, DailyPrice = 345, Description = "Arac markası Audidir", ModelYear = 2014 });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }
    }
}
