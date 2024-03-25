using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3
{
    class Motorcycle : Vehicle
    {
        private string EngineCapacity;
        private string FuelType;
        private string HasFairing;

        public void MotorcycleDetails()
        {
            Console.WriteLine("Enter the engine capacity:");
            string capacity = Console.ReadLine();
            EngineCapacity = capacity;

            Console.WriteLine("Enter fuel type:");
            string fuel = Console.ReadLine();
            FuelType = fuel;

            Console.WriteLine("Enter fairing type:");
            string fairing = Console.ReadLine();
            HasFairing = fairing;

        }
        public override void DisplayDetails()
        {
            Console.WriteLine("******Motorcycle Details******");
            Console.WriteLine($"Model : {Model}\n Manufacturer : {Manufacturer}\n Year of Manufacture : {Year}\n " +
                 $"Price of Vehicle : {RentalPrice} \n  Engine Capacity : {EngineCapacity} \n Fuel Type : {FuelType} \n Fairing: {HasFairing}");
        }
    }
}
