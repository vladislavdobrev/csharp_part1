using System;

class GCD
{
    static int SolveGCD(int n, int m)
    {
        if (n == m)
        {
            return n;
        }
        else if (n > m)
        {
            return SolveGCD(n - m, m);
        }
        else
        {
            return SolveGCD(n, m - n);
        }
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int m = int.Parse(Console.ReadLine());

        int result = SolveGCD(n, m);
        Console.WriteLine("The GCD of {0} and {1} is {2}", n, m, result);
    }
}
