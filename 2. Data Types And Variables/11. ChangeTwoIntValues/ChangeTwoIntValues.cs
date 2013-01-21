using System;

class ChangeTwoIntValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a = {0}; b = {1}", a, b);
        a += b;
        b = a - b;
        a -= b;
        Console.WriteLine("a = {0}; b = {1}", a, b);
    }
}
