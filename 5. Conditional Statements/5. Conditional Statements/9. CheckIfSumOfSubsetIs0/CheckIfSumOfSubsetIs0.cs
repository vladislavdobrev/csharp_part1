using System;
using System.Collections.Generic;

class CheckIfSumOfSubsetIs0
{
    static void Main()
    {
        int [] numbers = new int[5];
        Console.Write("Enter first number: ");
        numbers[0] = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        numbers[1] = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        numbers[2] = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        numbers[3] = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        numbers[4] = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                for (int k = j + 1; k < numbers.Length; k++)
                {
                    for (int l = k + 1; l < numbers.Length; l++)
                    {
                        for (int m = l + 1; m < numbers.Length; m++)
                        {
                            if (numbers[i] + numbers[j] + numbers[k] + numbers[l] + numbers[m] == 0)
                            {
                                Console.WriteLine("Subset: {{{0}, {1}, {2}, {3}, {4}}}",
                                    numbers[i], numbers[j], numbers[k], numbers[l], numbers[m]);
                            }
                        }
                        if (numbers[i] + numbers[j] + numbers[k] + numbers[l] == 0)
                        {
                            Console.WriteLine("Subset: {{{0}, {1}, {2}, {3}}}",
                                numbers[i], numbers[j], numbers[k], numbers[l]);
                        }
                    }
                    if (numbers[i] + numbers[j] + numbers[k] == 0)
                    {
                        Console.WriteLine("Subset: {{{0}, {1}, {2}}}",
                            numbers[i], numbers[j], numbers[k]);
                    }
                }
                if (numbers[i] + numbers[j] == 0)
                {
                    Console.WriteLine("Subset: {{{0}, {1}}}",
                        numbers[i], numbers[j]);
                }
            }
        }
    }
}
