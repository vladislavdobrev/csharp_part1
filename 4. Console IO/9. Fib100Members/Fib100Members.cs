using System;

class Fib100Members
{
    static void Main()
    {
        decimal lastLast = 0;
        decimal last = 0;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(lastLast + last);
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
    }
}
