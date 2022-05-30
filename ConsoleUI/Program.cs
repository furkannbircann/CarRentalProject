using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 1, ColorId = 12, ModelYear = "2000", DailyPrice = 500, Description = "Middle Class Car" });

            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} --- {1}", car.Id, car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //GetCarDetails(carManager);

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
