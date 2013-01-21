using System;

class PlusOrMinusFromThreeNumbers
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

        char sign = '\u0000';
        if (a == 0 || b == 0 || c == 0)
        {
            sign = '0';
        }
        else if (a > 0 && b > 0 && c > 0)
        {
            sign = '+';
        }
        else if (a > 0 && b > 0 && c < 0)
        {
            sign = '-';
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            sign = '-';
        }
        else if (a > 0 && b < 0 && c < 0)
        {
            sign = '+';
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            sign = '-';
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            sign = '+';
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            sign = '+';
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            sign = '-';
        }

        Console.WriteLine("The sign of a * b * c is {0}", sign);
    }
}
