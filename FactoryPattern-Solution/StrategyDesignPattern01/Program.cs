// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StrategyDesignPattern01;

Console.Write("Enter file name : ");
string fileName = Console.ReadLine();
Console.WriteLine("Enter File Type : \n1. Word \n2. Excel \n3. Text");
int fileType = int.Parse(Console.ReadLine());



FileCreatorContext fileCreatorContext = new FileCreatorContext();

if (fileType == 1)
{
    fileCreatorContext.SetStrategy(new WordFileCreator());
    fileCreatorContext.CreateFile(fileName);
}
else if (fileType == 2)
{
    fileCreatorContext.SetStrategy(new ExcelFileCreator());
    fileCreatorContext.CreateFile(fileName);
}
else if (fileType == 3)
{
    fileCreatorContext.SetStrategy(new TextFileCreator());
    fileCreatorContext.CreateFile(fileName);
}
else
{
    Console.WriteLine("No such option like that!!!");
}

