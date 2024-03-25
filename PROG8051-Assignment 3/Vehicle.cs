using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3
{
    //Vehicle Class
     abstract class  Vehicle
    {
        public string Model ;
        public string Manufacturer;
        public int Year;
        public double RentalPrice;

       /* public string VehicleModel { get { return Model; } set { Model = value; }}
        public string VehicleManufacturer { get { return Manufacturer; } set {  Manufacturer = value; }}
        public int MadeYear { get { return Year; } set {  Year = value; }}
        public double VehiclePrice { get { return RentalPrice; } set { RentalPrice = value; }}
       */
       public  void VehicleDetails()
        {
            Console.WriteLine("Enter the Model:");
           string  model = Console.ReadLine();
            Model = model;
            
            Console.WriteLine("Enter the Manufacturer:");
           string manufacturer = Console.ReadLine();
            Manufacturer = manufacturer;
       
            Console.WriteLine("Enter the Manufacture Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Year = year;
       
            Console.WriteLine("Enter the vehicle price:");
            double price = Convert.ToDouble(Console.ReadLine());

            RentalPrice = price; 
        }

        // To Display Details of Vehicles
        public abstract void DisplayDetails();
        

    }
}
