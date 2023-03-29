// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AbstractFactoryDesignPattern01;

IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

IBike regularBike = regularVehicleFactory.CreateBike();
regularBike.GetDetails();

ICar regularCar = regularVehicleFactory.CreateCar();
regularCar.GetDetails();

IBus regularBus = regularVehicleFactory.CreateBus();
regularBus.GetDetails();

Console.WriteLine("\n\n");

IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();

IBike sportsBike = sportsVehicleFactory.CreateBike();
sportsBike.GetDetails();

ICar sportsCar = sportsVehicleFactory.CreateCar();
sportsCar.GetDetails();

IBus sportsBus = sportsVehicleFactory.CreateBus();
sportsBus.GetDetails();
