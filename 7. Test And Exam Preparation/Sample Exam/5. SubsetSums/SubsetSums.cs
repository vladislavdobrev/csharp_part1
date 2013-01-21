using System;

class SubsetSums
{
    static void Main()
    {
        long s;
        byte n;
        s = long.Parse(Console.ReadLine());
        n = byte.Parse(Console.ReadLine());

        long[] numbers = new long[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        int result = 0;
        int numberOfCombinations = Convert.ToInt32(Math.Pow(2, n) - 1);
        for (int i = 1; i <= numberOfCombinations; i++)
        {
            long sumSoFar = 0;
            for (int j = 0; j < n; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sumSoFar += numbers[j];
                }
            }
            if (sumSoFar == s)
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}
