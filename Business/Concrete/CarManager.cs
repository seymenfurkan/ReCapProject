using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddNewCar(Car car)
        {
            _carDal.Add(car);
        }

        public void DeleteCar(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetCars()
        {
            // İş kodları ifler else ler vs..Eğer geçerse ....
            return _carDal.GetAll();
        }

        public void UpdateCar(Car car)
        {
            _carDal.Update(car);
        }
    }
}
