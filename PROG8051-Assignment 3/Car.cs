using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3
{
     class Car : Vehicle
    {
        private int Seats = 5;
        private string EngineType = "Petrol Engine";
        private string Transmission = "Automatic";
        private string Convertible = "Yes";


        public override void DisplayDetails()
        {
            Console.WriteLine($"Model : {Model}\n Manufacturer : {Manufacturer}\n Year of Manufacture : {Year}\n " +
                $"Price of Vehicle : {RentalPrice} \n Seats = {Seats}\n EngineType : {EngineType}\n Transmission: {Transmission}\n Convertible:{Convertible} ");

        }
    }
}
