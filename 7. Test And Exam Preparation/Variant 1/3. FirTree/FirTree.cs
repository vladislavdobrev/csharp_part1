using System;

class FirTree
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = (N * 2) - 3;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (i == N - 1)
                {
                    if (j == M / 2)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                else if ((i + j >= M / 2) && (i + j <= (M / 2) + 2 * i))
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
