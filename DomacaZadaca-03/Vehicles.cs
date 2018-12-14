using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class Vehicles : Inventory
    {
        public Vehicles() {}

        public Vehicles(DateTime registrationExpirationDate, int milage, int serialNumber, string description, DateTime purchaseDate, 
            int guarantee, int price, string manufacturer) 
            : base( serialNumber, description, purchaseDate, guarantee, price, manufacturer)
        {
            RegistrationExpirationDate = registrationExpirationDate;
            Milage = milage;
        }

        public DateTime RegistrationExpirationDate { get; set; }
        public int Milage { get; set; }

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
    }

}

