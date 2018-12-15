using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class Vehicles : Inventory
    {
        public Vehicles() {}

        public Vehicles(DateTime registrationExpirationDate, int milage, string description, DateTime purchaseDate, 
            int guarantee, int price, Manufacturer manufacturer) 
            : base(description, purchaseDate, guarantee, price, manufacturer)
        {
            SerialNumber = GenerateGuid();
            RegistrationExpirationDate = registrationExpirationDate;
            Milage = milage;
        }
        //public Guid SerialNumber { get; set; }
        public DateTime RegistrationExpirationDate { get; set; }
        public int Milage { get; set; }

        public override void PrintAll()
        {
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Purchase date: " + PurchaseDate);
            Console.WriteLine("Guarantee: " + Guarantee);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Manufacturer: " + _Manufacturer);
            Console.WriteLine("Mileage" + Milage);
            Console.WriteLine(" Registration Expiration Date: " + RegistrationExpirationDate);
            Console.WriteLine("\n\n");
        }
        public virtual void Delete(string SerialNumber, List<Vehicles> MyVehicle)
        {
            foreach (var VARIABLE in MyVehicle)
            {
                if (VARIABLE.SerialNumber.ToString() == SerialNumber)
                {
                    MyVehicle.Remove(VARIABLE);
                }
            }
        }

    }

}

