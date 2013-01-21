using System;

class BiggerOf2Numbers
{
    static void Main()
    {
        string num1, num2;
        Console.Write("1-st number: ");
        num1 = Console.ReadLine();
        Console.Write("2-nd number: ");
        num2 = Console.ReadLine();
        int intNum1 = int.Parse(num1);
        int intNum2 = int.Parse(num2);

        Console.WriteLine("The bigger: {0}", Math.Max(intNum1, intNum2));
    }
}
