using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DomacaZadaca_03
{
    class Functions
    {
        public static void PrintAllVehicles(List<Vehicles> MyVehicles)
        {
            Console.WriteLine("Vehicles\n");
            foreach (var VARIABLE in MyVehicles)
            {
                    VARIABLE.PrintAll();
                    Console.WriteLine("\n");
            }

            Console.WriteLine("\n\n");
        }
        public static void PrintAllInventory(List<Inventory> MyInventory)
        {
            Console.WriteLine("INVENTORY\n");
            foreach (var VARIABLE in MyInventory)
            {
                
                VARIABLE.PrintAll();
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n\n");
        }

        public static void PrintBySerialNumberInventory(string serialNum, List<Inventory> MyInventory)
        {
            foreach (var VARIABLE in MyInventory)
            {
                if (VARIABLE.SerialNumber == serialNum)
                {
                    VARIABLE.PrintAll();
                }
            }
        }

        public static void PrintByPhoneBrand(string Brand, List<MobilePhones> myPhones)
        {
            int cnt = 0;
            foreach (var VARIABLE in myPhones)
            {
                if (VARIABLE._Manufacturer.ToString().ToLower() == Brand.ToLower())
                {
                    VARIABLE.PrintAll();
                    cnt++;
                }
            }

            if (cnt == 0)
            {
                Console.WriteLine("No such brand in inventory");
            }
        }

        public static void PrintByOs(string OS, List<Computers> myComps)
        {
            foreach (var VARIABLE in myComps)
            {
                if (VARIABLE._OS.ToString().ToLower() == OS.ToLower())
                {
                    VARIABLE.PrintAll();
                }
            }
        }

        public static void PrintByPhoneExpirationDate(int year, List<MobilePhones> MyPhones)
        {
            foreach (var VARIABLE in MyPhones)
            {
                if (VARIABLE.RegistrationExpirationDate.Year == year)
                {
                    Console.WriteLine("Name: "+ VARIABLE.Name);
                    Console.WriteLine("Phone Number: " + VARIABLE.TelephoneNumber);
                }
            }
        }

        public static void NumberOfTechEquipWithBattery(List<TechEquipment> MyTechEquipment)
        {
            int cnt = 0;
            foreach (var VARIABLE in MyTechEquipment)
            {
                if (VARIABLE.Battery == true)
                {
                    cnt++;
                }
            }

            Console.WriteLine("Number of tech equipment with battery is " + cnt);
            
        }

        public static void NextVehicleExpirationdateMonth(List<Vehicles> MyVehicles)
        {

            DateTime NextMonth = DateTime.Now;
            
            foreach (var VARIABLE in MyVehicles)
            {
                if (VARIABLE.RegistrationExpirationDate.Month == 1  && NextMonth.Month == 12)
                {
                    VARIABLE.PrintAll();
                } 
                if (VARIABLE.RegistrationExpirationDate.Month - 1 == NextMonth.Month)
                {         
                    VARIABLE.PrintAll();
                }
            }

        }

        public static void VehicleSellingPrice(Vehicles MyVehicle)
        {
            float MinPrice = MyVehicle.Price * (20 / 100);
            float Sale = MyVehicle.Milage / 20000;
            float SellingPrice =MyVehicle.Price - (MyVehicle.Price * ((Sale*10)/100));
            float finalPrice;
            if (MinPrice > SellingPrice)
            {
                finalPrice = MinPrice;
            }
            else
            {
                finalPrice = SellingPrice;
            }

            float PriceDifference = MyVehicle.Price - finalPrice;
            Console.WriteLine("Price before: "+MyVehicle.Price);
            Console.WriteLine("Price after: "+ finalPrice);
            Console.WriteLine("You save: "+ PriceDifference);

        }

        public static void TechSellingPrice(TechEquipment myTech)
        {
            float MinPrice = myTech.Price * (30 / 100);
            TimeSpan ts = (DateTime.Now - myTech.PurchaseDate);
            double days = ts.TotalDays;
            days /= 30;
            int months = (int)days;
            int Sale = months * 5;
            float SellingPrice = myTech.Price - (myTech.Price * (Sale) / 100);
            float finalPrice;
            if (MinPrice > SellingPrice)
            {
                finalPrice = MinPrice;
            }
            else
            {
                finalPrice = SellingPrice;
            }
            //float SellingPrice
            float PriceDifference = myTech.Price - finalPrice;
            Console.WriteLine("Price before: " + myTech.Price);
            Console.WriteLine("Price after: " + finalPrice);
            Console.WriteLine("You save: " + PriceDifference);
        }
    }
}


