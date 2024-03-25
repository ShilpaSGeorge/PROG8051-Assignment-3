using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3.RentalAgency
{
     class RentalAgency : Vehicle
    {
        Car car1 = new Car();
       
      
        public double TotalRevenue;
  
        string [] fleet = new string[10];
        int count = 0;
        
       public void AddItems(string fleets) 
        { 
            fleet[count++] = fleets;
            DisplayDetails();
        }

        
        public void RemoveItem()
        {
            
        }

        public void RentItem()
        {

        }

        public override void DisplayDetails()
        {
            for(int i = 0;i < count;i++)
            {
                Console.WriteLine($"{fleet[i]}");
            }
            
            
        }
    }
}
