using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckImagesLimit(carImage.CarId), CheckValidFileType(formFile));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.AddAsync(formFile);
            carImage.CarImageDate = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(IFormFile formFile, CarImage carImage)
        {
            CarImage _carImage = _carImageDal.Get(ci => ci.CarImageId == carImage.CarImageId);
            File.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }
     
        public IDataResult<CarImage> GetById(int id)
        {
            var result = _carImageDal.Get(ci => ci.CarImageId == id);
          
            return new SuccessDataResult<CarImage>(result);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            var result = _carImageDal.GetAll();
            return new SuccessDataResult<List<CarImage>>(result);
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int CarId)
        {
            var result = _carImageDal.GetAll(ci => ci.CarImageId == CarId);
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(CarId));
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }


        //Business rules for car Image class
        private IResult CheckImagesLimit(int id)
        {
            return _carImageDal.GetAll(img => img.CarId == id).Count() < 5 ?
                new Result(true) : new ErrorResult(Messages.NumberOfPictureError);
        }

        private IResult CheckValidFileType(IFormFile file)
        {
            string[] supportedFileTypes = { ".jpg", ".jpeg", "png" };
          
            string extension = Path.GetExtension(file.FileName);
            for (int i = 0; i < supportedFileTypes.Length; i++)
            {
                if (extension == supportedFileTypes[i])
                {
                    return new SuccessResult();
                }
            }

            return new ErrorResult(Messages.InvalidFileType);
        }

        private List<CarImage> CheckIfCarImageNull(int id)
        {
            string path = @"\Images\logo.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = id, ImagePath = path, CarImageDate = DateTime.Now } };
            }
            return _carImageDal.GetAll(p => p.CarId == id);
        }



    }
}