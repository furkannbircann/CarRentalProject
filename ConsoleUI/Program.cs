using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            inMemoryCarDal.Add(new Car {Id=7,BrandId=2,ColorId=3,ModelYear="2015",DailyPrice=375,Description="Middle Class Car" });
            inMemoryCarDal.GetAll();
        }
    }
}
