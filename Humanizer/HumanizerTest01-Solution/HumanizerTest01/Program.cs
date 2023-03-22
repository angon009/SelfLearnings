using Humanizer;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;

#region Humanizing String
string stringForCaseTest = "this is a SenTence. which Is Pretty Much MESSed-Up";

Console.WriteLine("Test String :" + stringForCaseTest);

Console.WriteLine("To title case output : " + stringForCaseTest.Transform(To.TitleCase));

Console.WriteLine("To sentense case output : " + stringForCaseTest.Transform(To.SentenceCase));

Console.WriteLine("To lower and sentense case output : " + stringForCaseTest.Transform(To.LowerCase, To.SentenceCase));

Console.WriteLine("To lower and title case output : " + stringForCaseTest.Transform(To.LowerCase, To.TitleCase));

Console.WriteLine("After Truncation : " + stringForCaseTest.Truncate(10, "..."));
#endregion

#region Humanizing Enums
Console.WriteLine("Without Humanizing : " + TypeOfScience.PhysicalScience);
Console.WriteLine("With Humanizing : " + TypeOfScience.PhysicalScience.Humanize().Transform(To.TitleCase));

Console.WriteLine("Without Humanizing : " + TypeOfScience.AgriculturalScience);
Console.WriteLine("With Humanizing : " + TypeOfScience.AgriculturalScience.Humanize());

TypeOfScience typeOfScience = "Chemical Science".DehumanizeTo<TypeOfScience>();
Console.WriteLine("After Dehumanizing: " + typeOfScience);

typeOfScience = "This is the science of agricultures".DehumanizeTo<TypeOfScience>();
Console.WriteLine("After Dehumanizing : " + typeOfScience);
#endregion

#region Humanizing DateTime
Console.WriteLine("Before Humanizing : " + DateTime.Now);
Console.WriteLine("After Humanizing : " + DateTime.Now.Humanize());

Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(1));
Console.WriteLine("After Humanizing : " + DateTime.Now.AddDays(1).AddSeconds(1).Humanize());

Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(-2));
Console.WriteLine("After Humanizing : " + DateTime.Now.AddDays(-2).Humanize());

Console.WriteLine("Before Humanizing : " + TimeSpan.FromHours(42.5));
Console.WriteLine("After Humanizing : " + TimeSpan.FromHours(42.5).Humanize(3));
#endregion

#region Humanizing Numbers
Console.WriteLine("Before Humanizing : " + new TimeOnly(15, 15));
Console.WriteLine("After Humanizing : " + new TimeOnly(15, 30).ToClockNotation());

Console.WriteLine("7143 in words is : " + 7143.ToWords(false));

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"Ordinal Name of {i} is : " + i.ToOrdinalWords());
}

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"Roman value of {i} is : " + i.ToRoman());
}
Console.WriteLine("Numeric value of XIX is : " + "XIX".FromRoman());
#endregion

#region Humanizing Bytes/Bits
var memorySize = 35000.Gigabytes();
Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Bits} Bits");
Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Bytes} Bytes");
Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Megabytes} MB");
Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Terabytes} TB");
#endregion

#region Humanizing Degree values
Console.WriteLine(90d.ToHeading(HeadingStyle.Full));
Console.WriteLine(180d.ToHeading(HeadingStyle.Full));
Console.WriteLine(270d.ToHeading(HeadingStyle.Full));
Console.WriteLine(360d.ToHeading(HeadingStyle.Full));


Debug.Print(114d.ToHeadingArrow().ToString());
Debug.Print(200d.ToHeadingArrow().ToString());
Debug.Print(296d.ToHeadingArrow().ToString());
Debug.Print(333d.ToHeadingArrow().ToString());
#endregion



string bookName = "Book";
int count = 1;

if(count == 1)
{
    Console.WriteLine($"{count} {bookName.Singularize()}");
}
count ++;

if(count == 2)
{
    Console.WriteLine($"{count} {bookName.Pluralize()}");
}


enum TypeOfScience
{
    PhysicalScience,
    ChemicalScience,
    BiologicalScience,

    [Description("This is the science of agricultures")]
    AgriculturalScience
}
