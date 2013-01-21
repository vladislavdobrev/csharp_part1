using System;

class CountOfNumbersExactDevidedBy5
{
    static void Main()
    {
        string num1, num2;
        Console.Write("1-st number: ");
        num1 = Console.ReadLine();
        Console.Write("2-nd number: ");
        num2 = Console.ReadLine();
        uint uintNum1 = uint.Parse(num1);
        uint uintNum2 = uint.Parse(num2);

        int counter = 0;
        for (uint i = uintNum1; i <= uintNum2; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("The count of numbers devided by 5 with no reminder are: {0}", counter);
    }
}
