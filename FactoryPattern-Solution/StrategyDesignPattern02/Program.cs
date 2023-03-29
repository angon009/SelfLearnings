// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using StrategyDesignPattern02;

Console.WriteLine("Jaben??\n");

Console.Write("Enter Starting Point : ");
int startingPoint = int.Parse(Console.ReadLine());

Console.Write("Enter Ending Point : ");
int endingPoint = int.Parse(Console.ReadLine());

int distance = endingPoint - startingPoint;

Console.WriteLine("Choice Vehicle - \n1. Car\n2. Motorbike\n3. Rickshaw\n4. CNG\n5. Walk");
int vehicleType = int.Parse(Console.ReadLine());

ShareRideContext shareRideContext = new ShareRideContext();

if(vehicleType == 1)
{
    shareRideContext.SetRide(new Car());
    shareRideContext.CreateRide("Car", distance);
}
else if(vehicleType == 2)
{
    shareRideContext.SetRide(new MotorBike());
    shareRideContext.CreateRide("MotorBike", distance);
}
else if (vehicleType == 3)
{
    shareRideContext.SetRide(new Rickshaw());
    shareRideContext.CreateRide("Rickshaw", distance);
}
else if(vehicleType == 4)
{
    shareRideContext.SetRide(new CNG());
    shareRideContext.CreateRide("CNG", distance);
}
else if(vehicleType == 5)
{
    shareRideContext.SetRide(new Walk());
    shareRideContext.CreateRide("Walk", distance);
}
else
{
    Console.WriteLine("Start Flying!!!");
}