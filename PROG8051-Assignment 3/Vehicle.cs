using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

       /* public string VehicleModel { get { return Model; } set { Model = value; }}
        public string VehicleManufacturer { get { return Manufacturer; } set {  Manufacturer = value; }}
        public int MadeYear { get { return Year; } set {  Year = value; }}
        public double VehiclePrice { get { return RentalPrice; } set { RentalPrice = value; }}
       */
       public void VehicleModel()
        {
            Console.WriteLine("Enter the Model:");
            string model = Console.ReadLine();
            Model = model;
        }
        public void VehicleManufacturer(string manufacturer)
        {
            
            Manufacturer = manufacturer;


        }
        public void MadeYear(int year) 
        {  
         
            Year = year;
        }  
        public void VehiclePrice( double price) { RentalPrice = price; }

        // To Display Details of Vehicles
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model : {Model}\n Manufacturer : {Manufacturer}\n Year of Manufacture : {Year}\n Price of Vehicle : {RentalPrice}");
        }

    }
}
