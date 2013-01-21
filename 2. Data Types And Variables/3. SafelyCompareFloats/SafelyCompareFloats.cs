using System;

class SafelyCompareFloats
{
    static void Main()
    {
        string var1, var2;
        Console.Write("Enter 1st number: ");
        var1 = Console.ReadLine();
        Console.Write("Enter 2nd number: ");
        var2 = Console.ReadLine();
        double substrac = double.Parse(var1, System.Globalization.CultureInfo.GetCultureInfo("en-US"))
                        - double.Parse(var2, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        if (Math.Abs(substrac) < 0.000001)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
