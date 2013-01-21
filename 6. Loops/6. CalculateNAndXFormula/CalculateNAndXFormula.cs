using System;

class CalculateNAndXFormula
{
    static double factorial(int n)
    {
        double fact = 1.0d;
        for (double i = 1; i <= n; i++)
        {
            fact *= i;
        }

        return fact;
    }

    static void Main()
    {
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        double s = 1.0d;
        for (int i = 1; i <= n; i++)
        {
            s += factorial(i) / Math.Pow((double)x, (double)i);
        }

        Console.WriteLine("The result is {0:f3}.", s);
    }
}
