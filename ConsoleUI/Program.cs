using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Core.Utilities.Results;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //RentalTest();
            //UserAdd();

            //CarDetial();


            //BrandAdd();
            CarListe();

            //CarColorById();
            //CarAdd();

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2021, 1, 28)
            });
            Console.WriteLine(result.Message);
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User
            {
                FirstName = "Akif",
                LastName = "Geçmelik",
                Email = "adsa@daa.com"
            });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetial()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarId + " | " + car.BrandName + " | " + car.ColorName + " | " + car.DailyPrice);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 3, BrandName = "Anadol" });


        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 3,
                ModelYear = 2021,
                DailyPrice = 200,
                Description = "Temiz Araç"

            });
        }

        private static void CarColorById()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarByColorId(1);
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarByColorId(1).Data)
                {
                    Console.Write("Car Id = " + car.CarId + " | ");
                    Console.Write("Renk Id = " + car.ColorId + " | ");
                    Console.Write("Marka Id = " + car.BrandId + " | ");
                    Console.Write("Model = " + car.ModelYear + " | ");
                    Console.Write("Fiyat = " + car.DailyPrice + " | ");
                    Console.WriteLine("Açıklama =" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CarListe()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = carManager.GetAll();

            if (result.Success == true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.Write("Car Id = " + car.CarId + " | ");
                    Console.Write("Renk Id = " + car.ColorId + " | ");
                    Console.Write("Marka Id = " + car.BrandId + " | ");
                    Console.Write("Model = " + car.ModelYear + " | ");
                    Console.Write("Fiyat = " + car.DailyPrice + " | ");
                    Console.WriteLine("Açıklama =" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
