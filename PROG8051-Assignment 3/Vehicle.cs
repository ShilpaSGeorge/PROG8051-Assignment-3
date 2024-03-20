using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3
{
    //Vehicle Class
    class Vehicle
    {
        public string Model;
        public string Manufacturer;
        public int Year;
        public double RentalPrice;

        public string VehicleModel { get { return Model; } set { Model = value; }}
        public string VehicleManufacturer { get { return Manufacturer; } set {  Manufacturer = value; }}
        public int MadeYear { get { return Year; } set {  Year = value; }}
        public double VehiclePrice { get { return RentalPrice; } set { RentalPrice = value; }}

        // To Display Details of Vehicles
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model : {VehicleModel}\n Manufacturer : {VehicleManufacturer}\n Year of Manufacture : {MadeYear}\n Price of Vehicle : {VehiclePrice}");
        }

    }
}
