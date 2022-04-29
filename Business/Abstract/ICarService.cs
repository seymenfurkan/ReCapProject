using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        void AddNewCar(Car car);
        void DeleteCar(Car car);

        void UpdateCar(Car car);
    }
}
