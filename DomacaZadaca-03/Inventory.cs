using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class Inventory
    {
        public Inventory() {}

        public Inventory(int serialNumber, string description, DateTime purchaseDate, int guarantee, int price, string manufacturer)
        {
            SerialNumber = serialNumber;
            Description = description;
            PurchaseDate = purchaseDate;
            Guarantee = guarantee;
            Price = price;
            Manufacturer = manufacturer;
        }

        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Guarantee { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }

        
    }
}
