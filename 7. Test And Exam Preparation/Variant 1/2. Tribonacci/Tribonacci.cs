using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        long a1, a2, a3;
        int N;
        a1 = long.Parse(Console.ReadLine());
        a2 = long.Parse(Console.ReadLine());
        a3 = long.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());

        BigInteger result = 0;
        if (N == 1)
        {
            Console.WriteLine(a1);
        }
        else if (N == 2)
        {
            Console.WriteLine(a2);
        }
        else if (N == 3)
        {
            Console.WriteLine(a3);
        }
        else
        {
            BigInteger last = a3;
            BigInteger lastLast = a2;
            BigInteger lastLastLast = a1;
            for (int i = 4; i <= N; i++)
            {
                result = last + lastLast + lastLastLast;
                lastLastLast = lastLast;
                lastLast = last;
                last = result;
            }
            Console.WriteLine(result);
        }
    }
}
