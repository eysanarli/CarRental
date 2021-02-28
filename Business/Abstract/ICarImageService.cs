using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IResult Add(IFormFile formFile, CarImage carImage);
        IResult Update(IFormFile formFile,CarImage carImage);
        IResult Delete(IFormFile formFile,CarImage carImage);
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
    }
}
