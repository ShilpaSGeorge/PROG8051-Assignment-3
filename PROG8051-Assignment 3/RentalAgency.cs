using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3
{
     class RentalAgency : Vehicle
    {
        Car car = new Car();
        Truck truck;

        public double TotalRevenue;
        
        int count = 0;
        public RentalAgency()
        {
           string model
        }

        RentalAgency[] fleet = new RentalAgency[10]; 

        public void AddItems(RentalAgency fleets)
        {
            fleet[count++] = fleets;
            
        }
        public void RemoveItem()
        {

        }

        public override void DisplayDetails()
        {
            Console.WriteLine(Model);
            
        }
    }
}
