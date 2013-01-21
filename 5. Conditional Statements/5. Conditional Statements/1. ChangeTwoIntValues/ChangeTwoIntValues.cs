using System;

class ChangeTwoIntValues
{
    static void Main()
    {
        int a, b;
        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            a += b;
            b = a - b;
            a -= b;
        }

        Console.WriteLine("a = {0}\nb = {1}", a, b);
    }
}
