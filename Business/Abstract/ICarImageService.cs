using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int imageId);

        IResult Add(List<IFormFile> formFile, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(List<IFormFile> formFile, CarImage carImage);
    }

}
