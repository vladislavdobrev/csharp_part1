using System;

class Print1ToNWithout3And7Deviders
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (!(i % 3 == 0 && i % 7 == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}
