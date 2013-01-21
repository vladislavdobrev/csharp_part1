using System;

class NthCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal n = decimal.Parse(Console.ReadLine());

        // n = 0: 0! / 1! * 0! = 1
        // n = 1: 2! / 2! * 1! = 1
        // n = 2: 4! / 3! * 2! = 2
        // n = 3: 6! / 4! * 3! = 5
        // n = 4: 8! / 5! * 4! = 14
        // n = 5: 10! / 6! * 5! = 42

        decimal down = 1;
        for (decimal j = 1; j <= n; j++)
        {
            down *= j;
        }

        decimal up = 1;
        for (decimal i = n + 2; i <= 2 * n; i++)
        {
            up *= i;
            if (down != 1)
            {
                for (decimal k = 1; k < 10; k++)
                {
                    if (down % k == 0 && up % k == 0)
                    {
                        down /= k;
                        up /= k;
                    }
                }
            }
        }

        up /= down;

        Console.WriteLine("The result is {0}", up);
    }
}
