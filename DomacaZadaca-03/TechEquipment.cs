using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    class TechEquipment : Inventory
    {
        public TechEquipment() {}

        public TechEquipment(bool battery, int serialNumber, string description, DateTime purchaseDate, int guarantee, 
            int price, string manufacturer)
            : base(serialNumber, description, purchaseDate, guarantee, price, manufacturer)
        {
            Battery = battery;
        }

        public bool Battery { get; set; }
    }
}
