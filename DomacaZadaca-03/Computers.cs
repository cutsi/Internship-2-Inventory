using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class Computers : TechEquipment
    {
        public Computers() {}

        public Computers(DateTime registrationExpirationDate,bool portable, OS os, bool battery, string description, DateTime purchaseDate, int guarantee,
            int price, Manufacturer manufacturer)
            : base(registrationExpirationDate, battery, description, purchaseDate, guarantee, price, manufacturer)
        {
            SerialNumber = SerialNumber = GenerateGuid();
            Portable = portable;
            _OS = os;
        }
        
        public bool Portable { get; set; }
        public OS _OS { get; set; }
        public enum OS
        {
            MacOs = 1,
            Windows = 2,
            Linux = 3
        }
        public override void PrintAll()
        {
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Purchase date: " + PurchaseDate);
            Console.WriteLine("Guarantee: " + Guarantee);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Manufacturer: " + _Manufacturer);
            Console.WriteLine(" Registration Expiration Date: " + RegistrationExpirationDate);
            Console.WriteLine("Battery? " + Battery);
            Console.WriteLine("OS type: "+_OS);
            Console.WriteLine("\n\n");
        }

    }
}
