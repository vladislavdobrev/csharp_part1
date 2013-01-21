using System;

class TrapezoidArea
{
    static void Main()
    {
        string a = null;
        Console.Write("Enter side a: ");
        a = Console.ReadLine();
        double doubleA = double.Parse(a);
        string b = null;
        Console.Write("Enter side b: ");
        b = Console.ReadLine();
        double doubleB = double.Parse(b);
        string h = null;
        Console.Write("Enter height: ");
        h = Console.ReadLine();
        double doubleH = double.Parse(h);
        Console.WriteLine("Trapezoid's area is {0}", ((doubleA + doubleB) / 2) * doubleH);
    }
}
