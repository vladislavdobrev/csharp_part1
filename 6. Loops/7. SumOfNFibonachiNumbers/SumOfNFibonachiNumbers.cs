using System;

class SumOfNFibonachiNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        decimal lastLast = 0;
        decimal last = 0;
        decimal fibSum = 0;
        for (int i = 0; i < n; i++)
        {
            fibSum += lastLast + last;
            if (i == 0)
            {
                last++;
            }
            else if (i == 1)
            {
                continue;
            }
            else
            {
                decimal temp = lastLast;
                lastLast = last;
                last += temp;
            }
        }

        Console.WriteLine("The sum of first {0} members of fibonachi is {1}", n, fibSum);
    }
}
