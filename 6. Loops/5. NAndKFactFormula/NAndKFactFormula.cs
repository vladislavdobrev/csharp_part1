using System;

class NAndKFactFormula
{
    static void Main()
    {
        Console.Write("Enter K: ");
        decimal k = decimal.Parse(Console.ReadLine());
        Console.Write("Enter N: ");
        decimal n = decimal.Parse(Console.ReadLine());

        decimal substract = k - n;
        decimal factorial = 1;
        for (decimal i = substract + 1; i <= k; i++)
        {
            factorial *= i;
        }

        for (decimal j = 2; j <= n; j++)
		{
			 factorial *= j;
		}

        Console.WriteLine("N! * K! / (K - N)! = {0}", factorial);
    }
}
