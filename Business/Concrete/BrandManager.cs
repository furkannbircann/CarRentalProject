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
    public class BrandManager : IBrandService
    {
        IBrandDal _branDal;

        public BrandManager(IBrandDal branDal)
        {
            _branDal = branDal;
        }

        public IResult Add(Brand brand)
        {
            _branDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            _branDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_branDal.GetAll(),Messages.GetAll) ;
        }

        public IResult Update(Brand brand)
        {
            _branDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
    }
}
