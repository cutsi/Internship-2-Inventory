using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class Inventory
    {
        public Inventory() {}

        public Inventory(string description, DateTime purchaseDate, int guarantee, int price, Manufacturer manufacturer)
        {
            SerialNumber = GenerateGuid();
            Description = description;
            PurchaseDate = purchaseDate;
            Guarantee = guarantee;
            Price = price;
            _Manufacturer = manufacturer;
        }

        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Guarantee { get; set; }
        public int Price { get; set; }
        public Manufacturer _Manufacturer { get; set; }

        public string GenerateGuid()
        {
            var guid = Guid.NewGuid().ToString();
            return guid;
        }
        public string GetSerialNumber()
        {
            return SerialNumber;
        }
        public enum Manufacturer
        {
            Apple = 1,
            Samsung = 2,
            Xiaomi = 3,
            Lenovo = 4,
            HP = 5,
            Google = 6,

            Toyota = 7,
            Bmw = 8,
            Mercedes = 9,
            Opel = 10,
            Fiat = 11
        }
        
        public virtual void  PrintAll()
        {
            Console.WriteLine("Description: "+Description);
            Console.WriteLine("Purchase date: "+PurchaseDate);
            Console.WriteLine("Guarantee: "+ Guarantee);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine("Manufacturer: "+ _Manufacturer);
            Console.WriteLine( "Serial Number: "+ SerialNumber );
            Console.WriteLine("\n\n");

        }
    }

}
