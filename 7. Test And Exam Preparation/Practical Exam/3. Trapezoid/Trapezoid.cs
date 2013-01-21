using System;

class Trapezoid
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());

        for (int i = 0; i <= N; i++)
        {
            for (int j = 0; j < N * 2; j++)
            {
                if(i == 0 && (j >= N && j < N * 2))
                {
                    Console.Write('*');
                }
                else if (i == N)
                {
                    Console.Write('*');
                }
                else if (j + i == N)
                {
                    Console.Write('*');
                }
                else if (j == N * 2 - 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
