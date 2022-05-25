using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;

        public InMemoryCarDal()
        {
            _carList = new List<Car> { new Car { Id = 1, BrandId = 1, ColorId = 3, DailyPrice = 500, ModelYear = "2019", Description = "Middle Class Car" },
            new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 750, ModelYear = "2022", Description = "Luxury Car" },
            new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 250, ModelYear = "2010", Description = "Low Class Car" },
            new Car { Id = 4, BrandId = 3, ColorId = 5, DailyPrice = 300, ModelYear = "2015", Description = "Low Class Car" },
            new Car { Id = 5, BrandId = 1, ColorId = 4, DailyPrice = 450, ModelYear = "2018", Description = "Middle Class Car" },
            new Car { Id = 6, BrandId = 4, ColorId = 1, DailyPrice = 150, ModelYear = "2000", Description = "Low Class Car" }};
        }

        public void Add(Car car)
        {
            _carList.Add(car);
            Console.WriteLine("{0} -- {1} added to list",car.Id,car.Description);
        }

        public void Delete(Car car)
        {
            var carToDelete = _carList.SingleOrDefault(c=>c.Id == car.Id);
            _carList.Remove(carToDelete);
            Console.WriteLine("{0} -- {1} deleted to list", carToDelete.Id, carToDelete.Description);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void GetAll()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (var car in _carList)
            {
                Console.WriteLine("{0} -- {1} Model {2} {3} USD", car.Id, car.ModelYear, car.Description, car.DailyPrice);
            }
        }

        public Car GetById(int id)
        {
            return _carList.Find(c => c.Id == id);

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdate= _carList.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
