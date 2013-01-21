using System;

class NFactDevidedKFact
{
    static void Main()
    {
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int factoriel = 1;
        for (int i = n + 1; i <= k; i++)
        {
            factoriel *= i;
        }

        Console.WriteLine("N! / K! = {0:f3}", (double)1 / (double)factoriel);
    }
}
