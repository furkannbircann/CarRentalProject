using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        Car GetCarsByBrandId(int brandId);
        Car GetCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
