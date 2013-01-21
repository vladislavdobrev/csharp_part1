using System;

class ApplyingBonuses
{
    static void Main()
    {
        int digit = 0;
        Console.Write("Enter a number: ");
        bool parsePass = int.TryParse(Console.ReadLine(), out digit);

        if (parsePass && digit >= 0 && digit <= 9)
        {
            switch (digit)
            {
                case 0:
                    Console.WriteLine("Error.");
                    break;
                case 1:
                case 2:
                case 3:
                    digit *= 10;
                    Console.WriteLine(digit);
                    break;
                case 4:
                case 5:
                case 6:
                    digit *= 100;
                    Console.WriteLine(digit);
                    break;
                case 7:
                case 8:
                case 9:
                    digit *= 1000;
                    Console.WriteLine(digit);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error. Not a digit.");
        }
    }
}
