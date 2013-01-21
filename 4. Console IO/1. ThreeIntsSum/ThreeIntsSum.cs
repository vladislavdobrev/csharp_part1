using System;

class ThreeIntsSum
{
    static void Main()
    {
        string num1, num2, num3;
        Console.Write("Enter first number: ");
        num1 = Console.ReadLine();
        Console.Write("Enter second number: ");
        num2 = Console.ReadLine();
        Console.Write("Enter third number: ");
        num3 = Console.ReadLine();
        int sum = int.Parse(num1) + int.Parse(num2) + int.Parse(num3);
        Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2, num3, sum);
    }
}
