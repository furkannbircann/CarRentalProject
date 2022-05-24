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
            carManager.Add(new Car {Id=1,BrandId=1,ColorId=12,ModelYear="2000",DailyPrice=500,Description="Middle Class Car"});
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} --- {1}",car.Id,car.Description);
            }
        }
    }
}
