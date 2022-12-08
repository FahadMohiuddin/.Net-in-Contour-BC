Console.WriteLine("Enter Number");
var number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("User Defined");
if (number % 2 == 0)
{
    Console.WriteLine("{0} is Even Number",number);
}
else
{
    Console.WriteLine("{0} is Odd Number",number);
}



Console.WriteLine("Pre Defined By Loop");
for (int i = 1; i<= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("{0} is Even Number", i);
    }
    else
    {
        Console.WriteLine("{0} is Odd Number", i);
    }
}