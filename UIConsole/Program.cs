using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace UIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Id = 6, BrandId = 4, ColorId = 5, ModelYear = 2011, DailyPrice = 120, Description = "Station Vagon" };
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Eklenmiş Hali \n");
            carManager.AddNewCar(car1);
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("\n");
            car1.Description = "H-Back";
            carManager.UpdateCar(car1);
            Console.WriteLine("Güncellenmiş Hali \n");
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("\n");
            carManager.DeleteCar(car1);
            Console.WriteLine("Silinmiş Hali \n");
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("\n");
           
            
        }
    }
}
