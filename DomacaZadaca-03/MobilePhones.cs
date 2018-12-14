using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class MobilePhones : TechEquipment
    {
        public MobilePhones() {}

        public MobilePhones(DateTime registrationExpirationDate, int telephoneNumber, string name, bool battery, int serialNumber, string description, DateTime purchaseDate, int guarantee,
            int price, string manufacturer)
            : base(registrationExpirationDate, battery, serialNumber, description, purchaseDate, guarantee, price, manufacturer)
        {
            TelephoneNumber = telephoneNumber;
            Name = name;
        }

        public int TelephoneNumber { get; set; }
        public string Name { get; set; }
    }
}
