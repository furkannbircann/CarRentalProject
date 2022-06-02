using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rentalCar)
        {
            var isRental = _rentalDal.GetAll(r => r.CarId == rentalCar.CarId && (r.ReturnDate == null && r.ReturnDate > DateTime.Now)).Any();
            if (isRental)
            {
                return new ErrorResult(Messages.RentalInValid);
            }
            _rentalDal.Add(rentalCar);
            return new SuccessResult(Messages.RentalSuccess);
        }

        public IResult Delete(Rental rentalCar)
        {
            _rentalDal.Delete(rentalCar);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.GetAll);
        }

        public IResult Update(Rental rentalCar)
        {
            _rentalDal.Update(rentalCar);
            return new SuccessResult(Messages.Updated);
        }
    }
}
