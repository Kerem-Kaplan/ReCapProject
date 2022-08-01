using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,ColorId=1,BrandId=1,DailyPrice=400,ModelYear=2010,Description="Araç Markası Opel"},
                new Car{CarId=2,ColorId=2,BrandId=2,DailyPrice=300,ModelYear=2004,Description="Araç Markası Hyundai"},
                new Car{CarId=3,ColorId=2,BrandId=3,DailyPrice=500,ModelYear=2013,Description="Araç Markası Dacia"},
                new Car{CarId=4,ColorId=3,BrandId=4,DailyPrice=600,ModelYear=2016,Description="Araç Markası Nissan"},
                new Car{CarId=5,ColorId=4,BrandId=5,DailyPrice=700,ModelYear=2021,Description="Araç Markası Honda"}

            };
        }



        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
