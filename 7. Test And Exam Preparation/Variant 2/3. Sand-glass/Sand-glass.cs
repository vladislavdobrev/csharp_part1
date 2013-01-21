using System;

class Program
{
    static void Main()
    {
        byte number = byte.Parse(Console.ReadLine());
        string[,] sandClock = new string[number, number];

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                if ((j >= i && j < number - i) || (j <= i && j >= number - i - 1))
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