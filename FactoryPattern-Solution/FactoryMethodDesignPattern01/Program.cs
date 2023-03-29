// See https://aka.ms/new-console-template for more information
using FactoryMethodDesignPattern01;

//Console.WriteLine("Hello, World!");


Mobile mobile = new XiaomiFactory().CreateMobile();
Console.WriteLine("Brand : " + mobile.GetBrandName());
Console.WriteLine("Model : " + mobile.GetModelName());
Console.WriteLine("Operating System : " + mobile.GetOSName());
Console.WriteLine("Price : " + mobile.GetPrice() + "\n\n");


mobile = new SamsungFactory().CreateMobile();
Console.WriteLine("Brand : " + mobile.GetBrandName());
Console.WriteLine("Model : " + mobile.GetModelName());
Console.WriteLine("Operating System : " + mobile.GetOSName());
Console.WriteLine("Price : " + mobile.GetPrice());