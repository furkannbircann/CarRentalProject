using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars on r.CarId equals car.Id
                             join br in context.Brands on car.BrandId equals br.Id
                             join cr in context.Customers on r.CustomerId equals cr.Id
                             join usr in context.Users on cr.UserId equals usr.Id
                             select new RentalDetailDto { BrandName = br.BrandName, CustomerName = $"{usr.FirstName} {usr.LastName}", RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();
            }
        }
    }
}
