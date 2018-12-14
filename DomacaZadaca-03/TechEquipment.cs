using System;
using System.Collections.Generic;
using System.Text;

namespace DomacaZadaca_03
{
    public class TechEquipment : Inventory
    {
        public TechEquipment() {}

        public TechEquipment(DateTime registrationExpirationDate, bool battery, int serialNumber, string description, DateTime purchaseDate, int guarantee, 
            int price, string manufacturer)
            : base(serialNumber, description, purchaseDate, guarantee, price, manufacturer)
        {
            RegistrationExpirationDate = registrationExpirationDate;
            Battery = battery;
        }

        public DateTime RegistrationExpirationDate { get; set; }
        public bool Battery { get; set; }
    }
}
