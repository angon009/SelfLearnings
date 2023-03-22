# Humanizer

Converting values and code can be tricky. For example, if we rank something we will see that the top pick is in the first place,not in one place and the next one down would be in second place, not in two places. These types of conversions are easy to do by humans but these are tricky for software. But the humanize package makes this conversion easy. Ex: Converting 4.30pm to Half Past Four, Transforming string to be a specific enum value etc.

1. **Transforming string case :**

i. testString.Transform(To.TitleCase) : It will capitalize the first letter of all the words and it will convert all of the upper case letters to lowercase in between a word. But it will ignore if there is an all capital word like MOBILE, MANGO etc. Because it will consider this type of word as an acronym.

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.001.png)

ii. testString.Transform(To.SentenceCase) : It will capitalize the first letter of the entire string and the rest of the characters will be ignored even for a new line after dot.

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.002.png)

iii. We can chain these together to get the desired output. For example-

   <pre>testString..Transform(To.SentenceCase,To.LowerCase) </pre>

![](/Screenshots//Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.003.png)

iv. testString.Transform(To.LowerCase,To.SentenceCase) :

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.004.png)

vi. testString.Transform(To.LowerCase, To.TitleCase) :

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.005.png)

Thus, we can do various types of chaining to transform strings to get our desired output.

2. **Truncating string :**

Ex : stringForCaseTest.Truncate(10) : ![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.006.png)

We will get an ellipsis after the output sentence if we install utf-8 in our system. We can see the actual result on the debug screen.

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.007.png)

Here, ‘...’ will be considered as a single character. But we can also change this truncations character according to our own like this -

stringForCaseTest.Truncate(10, "...")

But here ‘...’ will be considered as a 3 character word and it will be truncated into 7 characters for the input string. ![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.008.png)

We can change the truncation characters according to our need.

3. **Humanizing Enum Values :**

We can get the enum values in more humanizing way like the below example :

<pre> 
enum TypeOfScience

{

`    `PhysicalScience,

`    `ChemicalScience,

`    `BiologicalScience,

`    `[Description("This is the Agricultural Science")]

`    `AgriculturalScience

}

Console.WriteLine("Without Humanizing : " + TypeOfScience.PhysicalScience);

Console.WriteLine("With Humanizing : " + TypeOfScience.PhysicalScience.Humanize().Transform(To.TitleCase));
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.009.png)

For those enum values which have a description it will print the description if we humanize it.

<pre>
Console.WriteLine("Without Humanizing : " + TypeOfScience.AgriculturalScience);

Console.WriteLine("With Humanizing : "+ TypeOfScience.AgriculturalScience.Humanize());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.010.png)

We can also dehumanize the values of our enum like that -

<pre>
TypeOfScience typeOfScience = "ChemicalScience".DehumanizeTo<TypeOfScience>();

Console.WriteLine("After Dehumanizing: " + typeOfScience);
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.011.png)

<pre>

typeOfScience = "This is the science of agricultures".DehumanizeTo<TypeOfScience>();

Console.WriteLine("After Dehumanizing : " + typeOfScience);
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.012.png)

4. **Humanizing Datetime :**

We can convert date time values as we humans say like tomorrow , yesterday.

<pre>
Console.WriteLine("Before Humanizing : " + DateTime.Now);

Console.WriteLine("After Humanizing : "+ DateTime.Now.Humanize());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.013.png)

<pre>
Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(1));

Console.WriteLine("After Humanizing : " + DateTime.Now.AddDays(1).Humanize());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.014.png)

This is happening because 1 second is lacking from this time. So, we have to add 1 second to this day.

<pre>
Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(1));

Console.WriteLine("After Humanizing : " + DateTime.Now.AddDays(1).AddSeconds(1).Humanize());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.015.png)

We can also get ‘yesterday' value.

<pre>
Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(-1));

Console.WriteLine("After Humanizing : " + DateTime.Now.AddDays(-1).Humanize());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.016.png)

<pre>
Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(-2));

Console.WriteLine("After Humanizing : " + DateTime.Now.AddDays(-2).Humanize());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.017.png)

We can also humanize the value of timespan. Like this -

<pre>
Console.WriteLine("Before Humanizing : " + TimeSpan.FromHours(42));

Console.WriteLine("After Humanizing : " + TimeSpan.FromHours(42).Humanize());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.018.png)

But the output is not totally precise, we can precise it through passing precision parameters from the .Humanize() method.

<pre>
Console.WriteLine("Before Humanizing : " + TimeSpan.FromHours(42));

Console.WriteLine("After Humanizing : " + TimeSpan.FromHours(42).Humanize(2));
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.019.png)

We can precise our output more than that.

<pre>
Console.WriteLine("Before Humanizing : " + TimeSpan.FromHours(42.5));

Console.WriteLine("After Humanizing : " + TimeSpan.FromHours(42.5).Humanize(3));
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.020.png)

We can also humanize the value of TimeOnly(). Like this-

<pre>
Console.WriteLine("Before Humanizing : " + new TimeOnly(15,15));

Console.WriteLine("After Humanizing : " + new TimeOnly(15, 15).ToClockNotation());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.021.png)

5. **Working with Numeric values :**

- We can convert our numeric numbers to words like this-
  <pre>
  Console.WriteLine("7143 in words is : " + 7143.ToWords());
  </pre>
  ![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.022.png)

But it’s not actually precise because in many terms ‘and’ should be used to denote numbers after a decimal point. So, seven thousand one hundred and forty-three will be denoted as : 7100.43

We can remove this and to get more precise value :

<pre>
Console.WriteLine("7143 in words is : " + 7143.ToWords(false));
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.023.png)

- We can get the ordinal name of numbers like this -
<pre>
for(int i = 1; i < 20; i++)

{

`    `Console.WriteLine($"Ordinal Name of {i} is : " + i.ToOrdinalWords());

}

</pre>
![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.024.png)

- We can get the roman values of numbers like this -

<pre>
for (int i = 1; i < 20; i++)

{

`    `Console.WriteLine($"Roman value of {i} is : " + i.ToRoman());

}
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.025.png)

We can also convert the roman signs into numeric values :

<pre>
Console.WriteLine("Numeric value of XIX is : " + "XIX".FromRoman());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.026.png)

6. **Converting bytes or bits :**

- We can interchange the bytes to Terabytes, Megabytes, Gigabytes etc and also humanize the value of bytes like this -\*\*
<pre>
var memorySize = 35000.Gigabytes();

Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Bits} Bits");

Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Bytes} Bytes");

Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Megabytes} MB");

Console.WriteLine($"{memorySize.Humanize()} = {memorySize.Terabytes} TB");

</pre>
![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.027.png)

7. **Converting degrees to directions :**

Just see the below code and its output :

<pre>
Console.WriteLine(90d.ToHeading(HeadingStyle.Full)); // d means ‘double’

Console.WriteLine(180d.ToHeading(HeadingStyle.Full));

Console.WriteLine(270d.ToHeading(HeadingStyle.Full));

Console.WriteLine(360d.ToHeading(HeadingStyle.Full));
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.028.png)

We can also get some directional signs :

<pre>
Debug.Print(114d.ToHeadingArrow().ToString()); // d means ‘double’

Debug.Print(200d.ToHeadingArrow().ToString());

Debug.Print(296d.ToHeadingArrow().ToString());

Debug.Print(333d.ToHeadingArrow().ToString());
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.029.png)

8. **Singularize and Pluralize Values based on the context :**

Humanizer can be used to pluralize or singularize words based on context. For example, "1 book" vs "2 books" like this -

<pre>
string bookName = "Book";

int count = 1;

if(count == 1)

{

`    `Console.WriteLine($"{count} {bookName.Singularize()}");

}

count ++;

if(count == 2)

{

`    `Console.WriteLine($"{count} {bookName.Pluralize()}");

}
</pre>

![](/Screenshots/Aspose.Words.d93f253e-28a6-4aa3-a6a1-47ca8bd0e87e.030.png)

The Humanizer library can be used in a wide range of applications where developers want to create more human-friendly user interfaces and experiences. Here are some examples of types of applications where Humanizer is commonly used:

**Web applications**: Humanizer is often used in web applications to format dates, times, and numbers in a way that is more user-friendly. It can also be used to pluralize or singularize words based on context.

**Mobile applications**: Humanizer can be used in mobile applications to create more readable and intuitive interfaces. For example, it can be used to display timestamps as "5 minutes ago" or to format phone numbers in a way that is more familiar to users.

**Desktop applications**: Humanizer can be used in desktop applications to make them more user-friendly and accessible. It can be used to format text in a more readable way, such as using title case for headings, or to provide localized text for different languages and cultures.

**Games**: Humanizers can be used in games to create more immersive and engaging experiences for players. For example, it can be used to format quest descriptions or dialogue in a way that is more natural and conversational.

Overall, Humanizer is a versatile library that can be used in many different types of applications to create more human-friendly experiences for users.
