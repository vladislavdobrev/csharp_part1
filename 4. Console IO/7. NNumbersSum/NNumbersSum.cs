using System;

class NNumbersSum
{
    static void Main()
    {
        Console.Write("How much numbers you will enter?: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("> ", i + 1);
            sum += int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of all input numbers is: {0}", sum);
    }
}
