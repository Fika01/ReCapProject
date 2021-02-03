using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.Write("Car Id = " + car.CarId + " | ");
                Console.Write("Renk Id = " + car.ColorId + " | ");
                Console.Write("Marka Id = " + car.BrandId + " | ");
                Console.Write("Model = " + car.ModelYear + " | ");
                Console.Write("Fiyat = " + car.DailyPrice + " | ");
                Console.WriteLine("Açıklama ="+car.Description);
                

            }

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
