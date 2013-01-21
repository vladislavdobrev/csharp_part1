using System;

class QuadraticEquation
{
    static void Main()
    {
        string a, b, c;
        Console.Write("Number a: ");
        a = Console.ReadLine();
        Console.Write("Number b: ");
        b = Console.ReadLine();
        Console.Write("Number c: ");
        c = Console.ReadLine();
        int intA = int.Parse(a);
        int intB = int.Parse(b);
        int intC = int.Parse(c);

        int d = intB * intB - 4 * intA * intC;
        double x1, x2;

        if (d == 0)
        {
            x1 = -intB / (2 * intA);
            Console.WriteLine("Both solutions are {0}.", x1);
        }
        else if (d < 0)
        {
            Console.WriteLine("The equation has no solutions.");
        }
        else
        {
            x1 = (-intB - Math.Sqrt(d)) / (2 * intA);
            x2 = (-intB + Math.Sqrt(d)) / (2 * intA);
            Console.WriteLine("The solutions are {0} and {1}.", x1, x2);
        }
    }
}
