using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class TechEquipment : Inventory
    {
        public TechEquipment() {}

        public TechEquipment(DateTime registrationExpirationDate, bool battery, string description, DateTime purchaseDate, int guarantee, 
            int price, Manufacturer manufacturer)
            : base( description, purchaseDate, guarantee, price, manufacturer)
        {
            SerialNumber = GenerateGuid();
            RegistrationExpirationDate = registrationExpirationDate;
            Battery = battery;
        }

        public DateTime RegistrationExpirationDate { get; set; }
        public bool Battery { get; set; }

        public override void PrintAll()
        {
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Purchase date: " + PurchaseDate);
            Console.WriteLine("Guarantee: " + Guarantee);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Manufacturer: " + _Manufacturer);
            Console.WriteLine(" Registration Expiration Date: " + RegistrationExpirationDate);
            Console.WriteLine("Battery? "+ Battery);
            Console.WriteLine("\n\n");
        }
    }
}
