using System;

class DevideBy5And7
{
    static void Main()
    {
        string number = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        bool result = intNumber % 5 == 0 && intNumber % 7 == 0;
        Console.WriteLine("Devide the number by 5 and 7 without reminder? {0}", result);
    }
}
