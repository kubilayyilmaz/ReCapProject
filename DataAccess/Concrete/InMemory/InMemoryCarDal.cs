using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2023, DailyPrice = 1192000, Description = "Corsa" },
                new Car { Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2023, DailyPrice = 1695000, Description = "Astra" },
                new Car { Id = 3, BrandId = 2, ColorId = 5, ModelYear = 2020, DailyPrice = 890000, Description = "Polo" },
                new Car { Id = 4, BrandId = 3, ColorId = 4, ModelYear = 2022, DailyPrice = 3600000, Description = "Taycan" },
                new Car { Id = 5, BrandId = 4, ColorId = 3, ModelYear = 2022, DailyPrice = 1250000, Description = "Sportage" },
            }; 
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var toBeDeletedCar = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(toBeDeletedCar!);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id)!;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var toBeUpdatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);

            toBeUpdatedCar!.BrandId = car.BrandId;
            toBeUpdatedCar.ColorId = car.ColorId;
            toBeUpdatedCar.ModelYear = car.ModelYear;
            toBeUpdatedCar.DailyPrice = car.DailyPrice;
            toBeUpdatedCar.Description = car.Description;
        }
    }
}
