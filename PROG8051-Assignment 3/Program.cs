using PROG8051_Assignment_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Vehicle Details");
Car car = new Car();
car.VehicleDetails();

car.DisplayDetails();
Truck truck = new Truck();
truck.VehicleDetails();

RentalAgency rentalAgency = new RentalAgency();
rentalAgency.DisplayDetails();
