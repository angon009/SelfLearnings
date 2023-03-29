// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern01;

Console.WriteLine("Hello, World!");


Console.WriteLine("Choose Vehicle Type :");
Console.WriteLine("1. Bus");
Console.WriteLine("2. Car");
Console.WriteLine("3. Motorbike");
Console.WriteLine("4. Truck");

var type = Console.ReadLine();

VehicleType vehicleType;
Enum.TryParse(type, true, out vehicleType);

Console.Write($"Enter {vehicleType} Price : ");
int vehiclePrice = int.Parse(Console.ReadLine());

Console.Write($"Enter {vehicleType} Count :  ");
int vehicleCount = int.Parse(Console.ReadLine());

Console.Write($"Enter {vehicleType} Model Name : ");
string vehicleName = Console.ReadLine();


Console.WriteLine();
Console.WriteLine();

VehicleDetails vehicleDetails = VehicleFactory.GetVehicleDetails(vehicleType);
Console.WriteLine(vehicleDetails.GetVehicleName(vehicleName + " details : "));
Console.WriteLine("Type : " + vehicleDetails.GetVehicleType());
Console.WriteLine("Price : " + vehicleDetails.GetVehiclePrice(vehiclePrice));
Console.WriteLine("Count : " + vehicleDetails.GetVehicleCount(vehicleCount));

int totalPrice = vehicleDetails.GetVehiclePrice(vehiclePrice) * vehicleDetails.GetVehicleCount(vehicleCount);
Console.WriteLine("Total Price : " + totalPrice);


/*
 Problems of Simple Factory Pattern in this example : 
    1. If we need to add any new type of vehicle then we need to add a new if else condition in the VehicleDetails method 
    of the VehicleFactory class. This violates the open-closed design principle(OCP).

    2. We also have a tight coupling between the VehilcleFactory class and Bus, Truc, Car classes.
 */