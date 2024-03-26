using PROG8051_Assignment_3;
using PROG8051_Assignment_3.RentalAgency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("******Welcome to Vehicle Rental Agency. Please enter your Vehicle Details******");

Car car = new Car();
car.VehicleDetails();
string model1;

model1 = car.Model;
char[] char1 = model1.ToCharArray();
car.CarDetails();
car.DisplayDetails();

Truck truck = new Truck();
truck.VehicleDetails();
string model2;
model2 = truck.Model;
char[] char2 = model2.ToCharArray();
truck.TruckDetails();
truck.DisplayDetails();

Motorcycle motorcycle = new Motorcycle();
motorcycle.VehicleDetails();
string model3;
model3 = motorcycle.Model;
char[] char3 = model3.ToCharArray();
motorcycle.MotorcycleDetails();
motorcycle.DisplayDetails();

RentalAgency rentalAgency = new RentalAgency();

rentalAgency.AddItems(model1);
rentalAgency.AddItems(model2);
rentalAgency.AddItems(model3);
Console.WriteLine("List of Vehicle Models Available");
rentalAgency.DisplayDetails();
rentalAgency.RemoveItem(model1);



