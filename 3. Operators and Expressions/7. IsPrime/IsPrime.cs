using System;

class IsPrime
{
    static void Main()
    {
        string number = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        double squareNumber = Math.Sqrt(intNumber);
        bool flag = true;
        for (int i = 2; i <= squareNumber; i++)
        {
            if (intNumber % i == 0)
            {
                flag = false;
                break;
            }
        }
        Console.WriteLine("The number is prime? {0}", flag);
    }
}
