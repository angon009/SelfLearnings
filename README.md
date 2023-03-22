**Humanizer**

Converting values and code can be tricky. For example, if we rank
something we will see that the top pick is in the first place,not in one
place and the next one down would be in second place, not in two places.
These types of conversions are easy to do by humans but these are tricky
for software. But the humanize package makes this conversion easy. Ex:
Converting 4.30pm to Half Past Four, Transforming string to be a
specific enum value etc.

1.  **Transforming string case :**

    a.  testString.Transform(To.TitleCase) : It will capitalize the
         first letter of all the words and it will convert all of the
        upper case letters to lowercase in between a word. But it will
        ignore if there is an all capital word like MOBILE, MANGO etc.
        Because it will consider this type of word as an acronym.
        ![](media/image12.png){width="6.5in"height="0.8472222222222222in"}

    b.  testString.Transform(To.SentenceCase) : It will capitalize the
        > first letter of the entire string and the rest of the
        > characters will be ignored even for a new line after dot.
        > ![](media/image26.png){width="6.5in"
        > height="0.7916666666666666in"}

    c.  We can chain these together to get the desired output. For
        > example-

        i.  testString..Transform(To.SentenceCase,To.LowerCase) :

> ![](media/image23.png){width="6.5in" height="0.5972222222222222in"}

i.  testString.Transform(To.LowerCase,To.SentenceCase) :

> ![](media/image2.png){width="6.5in" height="0.7638888888888888in"}

i.  testString.Transform(To.LowerCase, To.TitleCase) :
    > ![](media/image14.png){width="6.5in"
    > height="0.7638888888888888in"}

Thus, we can do various types of chaining to transform strings to get
our desired output.

2.  **Truncating string :**

> Ex : stringForCaseTest.Truncate(10) :
> ![](media/image4.png){width="6.5in" height="0.8611111111111112in"}
>
> We will get an ellipsis after the output sentence if we install utf-8
> in our system. We can see the actual result on the debug screen.
> ![](media/image7.png){width="6.5in" height="0.5208333333333334in"}
>
> Here, ‘...’ will be considered as a single character. But we can also
> change this truncations character according to our own like this -
>
> stringForCaseTest.Truncate(10, "...")
>
> But here ‘...’ will be considered as a 3 character word and it will be
> truncated into 7 characters for the input string.
> ![](media/image11.png){width="6.5in" height="0.8611111111111112in"}
>
> We can change the truncation characters according to our need.

3.  **Humanizing Enum Values :**

> We can get the enum values in more humanizing way like the below
> example :
>
> enum TypeOfScience
>
> {
>
> PhysicalScience,
>
> ChemicalScience,
>
> BiologicalScience,
>
> \[Description("This is the Agricultural Science")\]
>
> AgriculturalScience
>
> }
>
> Console.WriteLine("Without Humanizing : " +
> TypeOfScience.PhysicalScience);
>
> Console.WriteLine("With Humanizing : " +
> TypeOfScience.PhysicalScience.Humanize().Transform(To.TitleCase));
>
> ![](media/image5.png){width="5.84375in" height="1.2395833333333333in"}
>
> For those enum values which have a description it will print the
> description if we humanize it.
>
> Console.WriteLine("Without Humanizing : " +
> TypeOfScience.AgriculturalScience);
>
> Console.WriteLine("With Humanizing : "+
> TypeOfScience.AgriculturalScience.Humanize());
>
> ![](media/image6.png){width="5.765625546806649in" height="1.125in"}
>
> We can also dehumanize the values of our enum like that -
>
> TypeOfScience typeOfScience =
> "ChemicalScience".DehumanizeTo&lt;TypeOfScience&gt;();
>
> Console.WriteLine("After Dehumanizing: " + typeOfScience);
>
> ![](media/image3.png){width="5.645833333333333in"
> height="1.0416666666666667in"}
>
> typeOfScience = "This is the science of
> agricultures".DehumanizeTo&lt;TypeOfScience&gt;();
>
> Console.WriteLine("After Dehumanizing : " +
> typeOfScience);![](media/image9.png){width="5.640625546806649in"
> height="1.1145833333333333in"}

4.  **Humanizing Datetime :**

> We can convert date time values as we humans say like tomorrow ,
> yesterday.
>
> Console.WriteLine("Before Humanizing : " + DateTime.Now);
>
> Console.WriteLine("After Humanizing : "+ DateTime.Now.Humanize());
>
> ![](media/image27.png){width="5.630208880139983in" height="1.21875in"}
>
> Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(1));
>
> Console.WriteLine("After Humanizing : " +
> DateTime.Now.AddDays(1).Humanize());
>
> ![](media/image8.png){width="5.651042213473316in"
> height="1.2708333333333333in"}
>
> This is happening because 1 second is lacking from this time. So, we
> have to add 1 second to this day.
>
> Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(1));
>
> Console.WriteLine("After Humanizing : " +
> DateTime.Now.AddDays(1).AddSeconds(1).Humanize());
>
> ![](media/image1.png){width="5.703125546806649in" height="1.28125in"}
>
> We can also get ‘yesterday' value.
>
> Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(-1));
>
> Console.WriteLine("After Humanizing : " +
> DateTime.Now.AddDays(-1).Humanize());![](media/image28.png){width="5.713542213473316in"
> height="1.2291666666666667in"}
>
> Console.WriteLine("Before Humanizing : " + DateTime.Now.AddDays(-2));
>
> Console.WriteLine("After Humanizing : " +
> DateTime.Now.AddDays(-2).Humanize());
>
> ![](media/image10.png){width="5.796875546806649in"
> height="1.3229166666666667in"}
>
> We can also humanize the value of timespan. Like this -
>
> Console.WriteLine("Before Humanizing : " + TimeSpan.FromHours(42));
>
> Console.WriteLine("After Humanizing : " +
> TimeSpan.FromHours(42).Humanize());
>
> ![](media/image22.png){width="5.796875546806649in"
> height="1.3333333333333333in"}
>
> But the output is not totally precise, we can precise it through
> passing precision parameters from the .Humanize() method.
>
> Console.WriteLine("Before Humanizing : " + TimeSpan.FromHours(42));
>
> Console.WriteLine("After Humanizing : " +
> TimeSpan.FromHours(42).Humanize(2));
>
> ![](media/image16.png){width="5.796875546806649in"
> height="1.3020833333333333in"}
>
> We can precise our output more than that.
>
> Console.WriteLine("Before Humanizing : " + TimeSpan.FromHours(42.5));
>
> Console.WriteLine("After Humanizing : " +
> TimeSpan.FromHours(42.5).Humanize(3));
>
> ![](media/image21.png){width="5.776042213473316in"
> height="1.2395833333333333in"}
>
> We can also humanize the value of TimeOnly(). Like this-
>
> Console.WriteLine("Before Humanizing : " + new TimeOnly(15,15));
>
> Console.WriteLine("After Humanizing : " + new TimeOnly(15,
> 15).ToClockNotation());
>
> ![](media/image24.png){width="5.859375546806649in"
> height="1.2708333333333333in"}

5.  **Working with Numeric values :**

-   We can convert our numeric numbers to words like this-

> Console.WriteLine("7143 in words is : " + 7143.ToWords());
>
> ![](media/image30.png){width="5.932292213473316in"
> height="0.8645833333333334in"}
>
> But it’s not actually precise because in many terms ‘and’ should be
> used to denote numbers after a decimal point. So, seven thousand one
> hundred and forty-three will be denoted as : 7100.43
>
> We can remove this and to get more precise value :
>
> Console.WriteLine("7143 in words is : " + 7143.ToWords(false));
>
> ![](media/image29.png){width="5.979166666666667in"
> height="0.9479166666666666in"}

-   We can get the ordinal name of numbers like this -

> for(int i = 1; i &lt; 20; i++)
>
> {
>
> Console.WriteLine(\$"Ordinal Name of {i} is : " + i.ToOrdinalWords());
>
> }
>
> ![](media/image15.png){width="6.015625546806649in" height="5.59375in"}

-   We can get the roman values of numbers like this -

> for (int i = 1; i &lt; 20; i++)
>
> {
>
> Console.WriteLine(\$"Roman value of {i} is : " + i.ToRoman());
>
> }
>
> ![](media/image19.png){width="6.052083333333333in"
> height="5.572916666666667in"}
>
> We can also convert the roman signs into numeric values :
>
> Console.WriteLine("Numeric value of XIX is : " + "XIX".FromRoman());
>
> ![](media/image20.png){width="6.036458880139983in" height="1.125in"}

6.  **Converting bytes or bits :**

-   We can interchange the bytes to Terabytes, Megabytes, Gigabytes etc
    > and also humanize the value of bytes like this -

> var memorySize = 35000.Gigabytes();
>
> Console.WriteLine(\$"{memorySize.Humanize()} = {memorySize.Bits}
> Bits");
>
> Console.WriteLine(\$"{memorySize.Humanize()} = {memorySize.Bytes}
> Bytes");
>
> Console.WriteLine(\$"{memorySize.Humanize()} = {memorySize.Megabytes}
> MB");
>
> Console.WriteLine(\$"{memorySize.Humanize()} = {memorySize.Terabytes}
> TB");
>
> ![](media/image25.png){width="5.484375546806649in"
> height="1.8020833333333333in"}

7.  **Converting degrees to directions :**

> Just see the below code and its output :
>
> Console.WriteLine(90d.ToHeading(HeadingStyle.Full)); // d means
> ‘double’
>
> Console.WriteLine(180d.ToHeading(HeadingStyle.Full));
>
> Console.WriteLine(270d.ToHeading(HeadingStyle.Full));
>
> Console.WriteLine(360d.ToHeading(HeadingStyle.Full));
>
> ![](media/image13.png){width="4.6875in" height="1.8020833333333333in"}
>
> We can also get some directional signs :
>
> Debug.Print(114d.ToHeadingArrow().ToString()); // d means ‘double’
>
> Debug.Print(200d.ToHeadingArrow().ToString());
>
> Debug.Print(296d.ToHeadingArrow().ToString());
>
> Debug.Print(333d.ToHeadingArrow().ToString());
>
> ![](media/image18.png){width="4.052083333333333in"
> height="2.9166666666666665in"}

8.  **Singularize and Pluralize Values based on the context :**

> Humanizer can be used to pluralize or singularize words based on
> context. For example, "1 book" vs "2 books" like this -
>
> string bookName = "Book";
>
> int count = 1;
>
> if(count == 1)
>
> {
>
> Console.WriteLine(\$"{count} {bookName.Singularize()}");
>
> }
>
> count ++;
>
> if(count == 2)
>
> {
>
> Console.WriteLine(\$"{count} {bookName.Pluralize()}");
>
> }
>
> ![](media/image17.png){width="4.953125546806649in"
> height="1.4270833333333333in"}

The Humanizer library can be used in a wide range of applications where
developers want to create more human-friendly user interfaces and
experiences. Here are some examples of types of applications where
Humanizer is commonly used:

**Web applications**: Humanizer is often used in web applications to
format dates, times, and numbers in a way that is more user-friendly. It
can also be used to pluralize or singularize words based on context.

**Mobile applications**: Humanizer can be used in mobile applications to
create more readable and intuitive interfaces. For example, it can be
used to display timestamps as "5 minutes ago" or to format phone numbers
in a way that is more familiar to users.

**Desktop applications**: Humanizer can be used in desktop applications
to make them more user-friendly and accessible. It can be used to format
text in a more readable way, such as using title case for headings, or
to provide localized text for different languages and cultures.

**Games**: Humanizers can be used in games to create more immersive and
engaging experiences for players. For example, it can be used to format
quest descriptions or dialogue in a way that is more natural and
conversational.

Overall, Humanizer is a versatile library that can be used in many
different types of applications to create more human-friendly
experiences for users.
