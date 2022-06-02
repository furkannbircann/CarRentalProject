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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer  {UserId = 1, CompanyName = "X Technology" });

            //CarGetAll();

            //GetCarDetails(carManager);

        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 12, CarName = "Honda", ModelYear = new DateTime(2000), DailyPrice = 500, Description = "Middle Class Car" });

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
