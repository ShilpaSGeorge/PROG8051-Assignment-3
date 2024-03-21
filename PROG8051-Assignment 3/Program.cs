

using PROG8051_Assignment_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vehicle Details");
            Car car = new Car();
            car.VehicleModel();
            car.VehicleManufacturer("TATA");
            car.MadeYear(2020);
            car.VehiclePrice(2000.90);
            car.DisplayDetails();


        }
    }
}
