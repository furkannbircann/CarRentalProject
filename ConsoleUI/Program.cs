using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarGetAll();

            //GetCarDetails(carManager);

        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} --- {1}", car.Id, car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetails(CarManager carManager)
        {
            foreach (var detail in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} --- {1} --- {2} --- {3}", detail.CarName, detail.BrandName, detail.ColorName, detail.DailyPrice);
            }
        }
    }
}
