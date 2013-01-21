using System;

class SortThreeInts
{
    static void Main()
    {
        int a, b, c;
        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        c = int.Parse(Console.ReadLine());

        int biggest = a, bigger = 0, smallest = 0;
        if (b >= biggest)
        {
            if (b >= c)
            {
                biggest = b;
                if (c >= a)
                {
                    bigger = c;
                    smallest = a;
                }
                else
                {
                    bigger = a;
                    smallest = c;
                }
            }
            else
            {
                biggest = c;
                bigger = b;
                smallest = a;
            }
        }
        else
        {
            if (c >= biggest)
            {
                biggest = c;
                bigger = a;
                smallest = b;
            }
            else
            {
                biggest = a;
                if (c >= b)
                {
                    bigger = c;
                    smallest = b;
                }
                else
                {
                    bigger = b;
                    smallest = c;
                }
            }
        }
        Console.WriteLine("{0} {1} {2}", biggest, bigger, smallest);
    }
}
