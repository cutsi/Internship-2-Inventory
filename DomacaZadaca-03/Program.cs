using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using static DomacaZadaca_03.Functions;
namespace DomacaZadaca_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var VehicleList = new List<Vehicles>();
            var Vehicle1 = new Vehicles(new DateTime(2019, 1, 1), 150000, "a car", new DateTime(2019, 1, 23), 12, 24000, Inventory.Manufacturer.Bmw);
            var Vehicle2 = new Vehicles(new DateTime(2014, 3, 23), 400000, "a car", new DateTime(2018, 6, 23), 24, 28000, Inventory.Manufacturer.Mercedes);
            var Vehicle3 = new Vehicles(new DateTime(2014, 3, 23), 50000, "a car", new DateTime(2020, 6, 23), 24, 21000, Inventory.Manufacturer.Fiat);
            VehicleList.Add(Vehicle1);
            VehicleList.Add(Vehicle2);
            VehicleList.Add(Vehicle3);


            var InventoryList = new List<Inventory>();
            var Inventory1 = new Inventory("Phone case", new DateTime(2018,12,12), 6,50,Inventory.Manufacturer.Apple );
            var Inventory2 = new Inventory("Ear plugs", new DateTime(2014,4,8), 6, 40, Inventory.Manufacturer.Samsung);
            var Inventory3 = new Inventory("Charger", new DateTime(2015,7,9), 6, 80, Inventory.Manufacturer.Xiaomi);
            InventoryList.Add(Inventory1);
            InventoryList.Add(Inventory2);
            InventoryList.Add(Inventory3);

            var TechEquipmentList = new List<TechEquipment>();
            var tech1 = new TechEquipment(new DateTime(2018,4,7), true, "tablet", new DateTime(2018,4,9), 12, 100, Inventory.Manufacturer.Apple  );
            var tech2 = new TechEquipment(new DateTime(2018, 4, 7), false, "DVD player", new DateTime(2018, 6, 9), 12, 200, Inventory.Manufacturer.Lenovo);
            var tech3 = new TechEquipment(new DateTime(2017, 4, 7), true, "AC", new DateTime(2018, 3, 9), 12, 800, Inventory.Manufacturer.Xiaomi);
            TechEquipmentList.Add(tech1);
            TechEquipmentList.Add(tech2);
            TechEquipmentList.Add(tech3);

            var ComputerList = new List<Computers>();
            var comp1 = new Computers(new DateTime(2019,4,6), false, Computers.OS.MacOs, false, "brand new computer", new DateTime(2016, 11, 8), 12, 1200, Inventory.Manufacturer.HP );
            var comp2 = new Computers(new DateTime(2019, 1, 8), false, Computers.OS.Linux, false, "brand new samsung computer", new DateTime(2017, 12, 8), 12, 1400, Inventory.Manufacturer.Apple);
            var comp3 = new Computers(new DateTime(2018, 4, 6), false, Computers.OS.Windows, false, "used computer in good conditions", new DateTime(2017, 8, 8), 12, 800, Inventory.Manufacturer.Lenovo);
            ComputerList.Add(comp1);
            ComputerList.Add(comp2);
            ComputerList.Add(comp3);


            var PhoneList = new List<MobilePhones>();
            var phone1 = new MobilePhones(new DateTime(2019,12,12), 0923329275, "Josip Cutura", true, "brand new phone", new DateTime(2017,12,8), 18, 800, Inventory.Manufacturer.Xiaomi);
            var phone2 = new MobilePhones(new DateTime(2019, 8, 12), 0923329276, "Josip Maric", true, "brand new phone", new DateTime(2017, 4, 8), 18, 1600, Inventory.Manufacturer.Apple);
            var phone3 = new MobilePhones(new DateTime(2019, 9, 12), 0923329277, "Ivica Ivic", true, "brand new phone", new DateTime(2016, 12, 8), 18, 400, Inventory.Manufacturer.Samsung);
            PhoneList.Add(phone1);
            PhoneList.Add(phone2);
            PhoneList.Add(phone3);


            TechSellingPrice(tech1);
            VehicleSellingPrice(Vehicle1);
            PrintByOs("linux",ComputerList);
            NextVehicleExpirationdateMonth(VehicleList);
            PrintByPhoneExpirationDate(2019,PhoneList);
            PrintByPhoneBrand("samsung",PhoneList);
            NumberOfTechEquipWithBattery(TechEquipmentList);
            PrintByPhoneExpirationDate(2018,PhoneList);
            PrintAllInventory(InventoryList);
            PrintBySerialNumberInventory(Inventory1.GetSerialNumber(), InventoryList);
            Vehicle3.GetSerialNumber();
            PrintAllVehicles(VehicleList);
            DeleteInventoryItem(Inventory1,InventoryList);
            PrintAllInventory(InventoryList);
            DeleteComputerItem(comp1,ComputerList);
            DeletePhoneItem(phone1,PhoneList);
            DeleteTechEquipmentItem(tech1,TechEquipmentList);
            DeleteVehicleItem(Vehicle1,VehicleList);
        }
    }
}
