using System;

class OddOrEven
{
    static void Main()
    {
        string number = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        int expression = intNumber % 2;
        string result = expression == 0 ? "Even" : "Odd";
        Console.WriteLine("The number is {0}", result);
    }
}
