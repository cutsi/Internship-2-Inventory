using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace DomacaZadaca_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //var MyVehicle = new Vehicles(new DateTime(2013, 1, 23), 1 ,2, "a car", new DateTime(2014, 1, 23), 12, 2400, "toyota");
            var allVehicleList = InsertVehicles();
            PrintBySerialNumber(2,allVehicleList);
            PrintByVehicleExpirationDate(2020, allVehicleList);
        }
        public static void PrintBySerialNumber(int SerialNum, List<Vehicles> MyInventory)
        {
            foreach (var VARIABLE in MyInventory)
            {
                if (VARIABLE.SerialNumber == SerialNum)
                {
                    Console.WriteLine(VARIABLE.Description);
                    Console.WriteLine(VARIABLE.Guarantee);
                    Console.WriteLine(VARIABLE.Manufacturer);
                    Console.WriteLine(VARIABLE.Price);
                }
            }

        }

        public static void PrintByVehicleExpirationDate(int year, List<Vehicles> MyInventory)
        {
            foreach (var VARIABLE in MyInventory)
            {
                if (VARIABLE.RegistrationExpirationDate.Year == year)
                {
                    Console.WriteLine(VARIABLE.Description);
                    Console.WriteLine(VARIABLE.Guarantee);
                    Console.WriteLine(VARIABLE.Manufacturer);
                    Console.WriteLine(VARIABLE.Price);
                }
            }
        }

        public static void PrintByBatter(List<TechEquipment> MyEquipment)
        {
            foreach (var VARIABLE in MyEquipment)
            {
                if (VARIABLE.Battery == true)
                {
                    Console.WriteLine(VARIABLE.Description);
                    Console.WriteLine(VARIABLE.Guarantee);
                    Console.WriteLine(VARIABLE.Manufacturer);
                    Console.WriteLine(VARIABLE.Price);
                }
            }
        }

        public static void PrintByPhoneBrand(string Brand, List<MobilePhones> myPhones)
        {
            foreach (var VARIABLE in myPhones)
            {
                if (VARIABLE.Manufacturer == Brand)
                {
                    Console.WriteLine(VARIABLE.Description);
                    Console.WriteLine(VARIABLE.Guarantee);
                    Console.WriteLine(VARIABLE.Manufacturer);
                    Console.WriteLine(VARIABLE.Price);
                }
            }
        }

        public static void PrintByOs(string OS, List<Computers> myComps)
        {
            foreach (var VARIABLE in myComps)
            {
                if (VARIABLE.OS == OS)
                {
                    Console.WriteLine(VARIABLE.Description);
                    Console.WriteLine(VARIABLE.Guarantee);
                    Console.WriteLine(VARIABLE.Manufacturer);
                    Console.WriteLine(VARIABLE.Price);
                }
            }
        }

        public static void PrintByPhoneExpirationDate(int year, List<MobilePhones> MyPhones)
        {
            foreach (var VARIABLE in MyPhones)
            {
                if (VARIABLE.RegistrationExpirationDate.Year == year)
                {
                    Console.WriteLine(VARIABLE.Description);
                    Console.WriteLine(VARIABLE.Guarantee);
                    Console.WriteLine(VARIABLE.Manufacturer);
                    Console.WriteLine(VARIABLE.Price);
                }
            }
        }

        public static List<Vehicles> InsertVehicles()
        {
            var allVehicleList = new List<Vehicles>()
            {
                new Vehicles()
                {
                    RegistrationExpirationDate = new DateTime(2020, 1, 23), Milage = 24000, SerialNumber = 20,
                    Description = "In an excellent condition", Guarantee = 12, Price = 25000,
                    PurchaseDate = new DateTime(2016, 1, 3), Manufacturer = "Toyota"
                },
                new Vehicles()
                {
                    RegistrationExpirationDate = new DateTime(2022, 1, 23), Milage = 24400, SerialNumber = 2,
                    Description = "In an excellent condition", Guarantee = 24, Price = 250000,
                    PurchaseDate = DateTime.Today, Manufacturer = "Mercedes"
                }
            };
            return allVehicleList;
        }
    }
}
