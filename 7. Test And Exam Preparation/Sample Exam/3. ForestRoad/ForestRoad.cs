using System;

class ForestRoad
{
    static void Main()
    {
        int w;
        w = int.Parse(Console.ReadLine());
        int h = 2 * w - 1;

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (i == j || i + j == h - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}