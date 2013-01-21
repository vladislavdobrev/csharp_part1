using System;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int zeroes = 0;
        int rank = 1;
        for (int i = 5; i <= n; i = (int)Math.Pow(5, rank))
        {
            if (n >= i)
            {
                zeroes += n / i;
            }
            rank++;
        }

        Console.WriteLine("The trailing zeroes in {0}! are {1}", n, zeroes);
    }
}
