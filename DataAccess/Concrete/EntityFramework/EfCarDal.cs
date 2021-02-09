using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindRentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            using (NorthwindRentACarContext context = new NorthwindRentACarContext())
            {
                var result = from cr in filter is null ? context.Cars : context.Cars.Where(filter)
                             join br in context.Brands
                             on cr.BrandId equals br.BrandId
                             join clr in context.Colors
                             on cr.ColorId equals clr.ColorId
                             select new CarDetailDto
                             {
                                 Id = cr.CarId,
                                 BrandId = br.BrandId,
                                 ColorId = clr.ColorId,
                                 BrandName = br.BrandName,
                                 ColorName = clr.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 Descriptions = cr.Descriptions,
                                 ModelYear = cr.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
