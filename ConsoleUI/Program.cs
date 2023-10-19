using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach(var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }

            carManager.Add(new Car
            {
                BrandId = 4,
                ColorId = 2,
                DailyPrice = 1500,
                ModelYear = 2022,
                Description = "320i"
            });

        }
    }
}