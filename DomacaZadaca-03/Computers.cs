using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    class Computers : TechEquipment
    {
        public Computers() {}

        public Computers(bool portable, string os, bool battery, int serialNumber, string description, DateTime purchaseDate, int guarantee,
            int price, string manufacturer)
            : base(battery, serialNumber, description, purchaseDate, guarantee, price, manufacturer)
        {
            Portable = portable;
            OS = os;
        }

        public bool Portable { get; set; }
        public string OS { get; set; }
    }
}
