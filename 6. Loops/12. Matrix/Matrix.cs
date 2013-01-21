using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j <= n + i; j++)
            {
                Console.Write(j + "\t");
            }
            Console.WriteLine();
        }
    }
}
