using System;

class MinAndMaxOfNNumbers
{
    static void Main()
    {
        Console.Write("How much numbers you'll enter: ");
        int n = int.Parse(Console.ReadLine());
        int biggest = 0;
        int smallest = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Number {0}: ", i);
            int number = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                biggest = number;
                smallest = number;
            }
            else
            {
                if (number > biggest)
                {
                    biggest = number;
                }
                else if (number < smallest)
                {
                    smallest = number;
                }
            }
        }

        Console.WriteLine("Biggest: {0}\nSmallest: {1}", biggest, smallest);
    }
}
