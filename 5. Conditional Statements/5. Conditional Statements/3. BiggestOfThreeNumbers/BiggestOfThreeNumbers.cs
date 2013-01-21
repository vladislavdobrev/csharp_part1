using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        int a, b, c;
        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        c = int.Parse(Console.ReadLine());

        int biggest = a;
        if (b >= biggest)
        {
            if (b >= c)
            {
                biggest = b;
            }
            else
            {
                biggest = c;
            }
        }
        else
        {
            if (c >= biggest)
            {
                biggest = c;
            }
        }
        Console.WriteLine("The biggest of the numbers is {0}", biggest);
    }
}
