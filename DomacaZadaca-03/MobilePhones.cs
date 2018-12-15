using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class MobilePhones : TechEquipment
    {
        public MobilePhones() {}

        public MobilePhones(DateTime registrationExpirationDate, int telephoneNumber, string name, bool battery, string description, DateTime purchaseDate, int guarantee,
            int price, Manufacturer manufacturer)
            : base(registrationExpirationDate, battery, description, purchaseDate, guarantee, price, manufacturer)
        {
            SerialNumber = SerialNumber = GenerateGuid();
            TelephoneNumber = telephoneNumber;
            Name = name;
        }

        public int TelephoneNumber { get; set; }
        public string Name { get; set; }

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
            Console.WriteLine("Telephone number: "+TelephoneNumber);
            Console.WriteLine("Users name: "+Name);

        }
    }
}
