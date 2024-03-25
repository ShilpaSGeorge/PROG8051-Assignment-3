using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3
{
    class Truck : Vehicle
    {
        private int Capacity;
        private string TruckType = "Large";
        private string FourWheelDDrive = "Yes";

        public void TruckDetails()
        {
            Console.WriteLine("Enter the capacity:");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Capacity = capacity;

            Console.WriteLine("Enter truck type:");
            string truck = Console.ReadLine();
            TruckType = truck;

            Console.WriteLine("Enter drive type:");
            string drive = Console.ReadLine();
            FourWheelDDrive = drive;

        }

        public override void DisplayDetails()
        {
            Console.WriteLine("******Truck Details******");
            Console.WriteLine($"Model : {Model}\n Manufacturer : {Manufacturer}\n Year of Manufacture : {Year}\n " +
                 $"Price of Vehicle : {RentalPrice} \n Capacity : {Capacity} \n Truck Type : {TruckType} \n Drive : {FourWheelDDrive}");
        }
    }
}
