using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    class MobilePhones : TechEquipment
    {
        public MobilePhones() {}

        public MobilePhones(int telephoneNumber, string name, bool battery, int serialNumber, string description, DateTime purchaseDate, int guarantee,
            int price, string manufacturer)
            : base(battery, serialNumber, description, purchaseDate, guarantee, price, manufacturer)
        {
            TelephoneNumber = telephoneNumber;
            Name = name;
        }

        public int TelephoneNumber;
        public string Name;
    }
}
