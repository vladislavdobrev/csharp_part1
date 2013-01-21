using System;
using System.Threading;
using System.Globalization;

class SumOfPlusMinus1DevidedByN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 1.0d;
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum += (double)1 / (double)i;
            }
            else
            {
                sum -= (double)1 / (double)i;
            }
        }

        if (n <= 5)
        {
            Console.WriteLine("The sum is {0:f3}", sum);
        }
        else if (n % 2 == 0)
        {
            Console.WriteLine("The sum of 1 + 1/2 - 1/3 ... - 1/{0} + 1/{1} = {2:f3}", n - 1, n, sum);
        }
        else
        {
            Console.WriteLine("The sum of 1 + 1/2 - 1/3 ... + 1/{0} - 1/{1} = {2:f3}", n - 1, n, sum);
        }
    }
}
