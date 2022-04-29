using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
           _cars = new List<Car>
           {
               new Car { Id = 1, BrandId = 1 ,ColorId = 1, ModelYear = 2019, DailyPrice = 130, Description ="SUV"},
               new Car { Id = 2, BrandId = 1 ,ColorId = 4, ModelYear = 2020, DailyPrice = 150, Description ="B-SUV"},
               new Car { Id = 3, BrandId = 2 ,ColorId = 3, ModelYear = 2021, DailyPrice = 170, Description ="A-SUV"},
               new Car { Id = 4, BrandId = 3 ,ColorId = 5, ModelYear = 2022, DailyPrice = 190, Description ="Binek"},
               new Car { Id = 5, BrandId = 3 ,ColorId = 2, ModelYear = 2023, DailyPrice = 210, Description ="Yarış"},
           };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            //Düzeltilecek
           return _cars.Where(c => c.Id == carId).ToList();
        }

        
    }
}
