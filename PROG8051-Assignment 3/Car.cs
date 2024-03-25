using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3
{
     class Car : Vehicle
    {
        
        private int Seats;
        private string EngineType;
        private string Transmission ;
        private string Convertible = "Yes";

        public void CarDetails()
        {
            Console.WriteLine("Enter the seats:");
            int seats = Convert.ToInt32(Console.ReadLine());
            Seats = seats;

            Console.WriteLine("Enter engine type:");
            string type = Console.ReadLine();
            EngineType = type;

            Console.WriteLine("Enter transmission type:");
            string transmission = Console.ReadLine();   
            Transmission = transmission;

            Console.WriteLine("Enter the conversion type:");
            string convertible = Console.ReadLine();
            Convertible = convertible;
        }
        
        public override void DisplayDetails()
        {
            
              Console.WriteLine("******Car Details******");
             Console.WriteLine($"Model : {Model}\n Manufacturer : {Manufacturer}\n Year of Manufacture : {Year}\n " +
            $"Price of Vehicle : {RentalPrice} \n Seats = {Seats}\n EngineType : {EngineType}\n Transmission: {Transmission}\n Convertible:{Convertible} ");
           
        }
    }
}
