using System;

class CheckThirdDigit
{
    static void Main()
    {
        string number = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        bool result = false;
        if (intNumber >= 700)
        {
            int checkThird = (intNumber / 100) % 10;
            result = checkThird == 7 ? true : false;
        }
        Console.WriteLine("Is third digit 7? {0}", result);
    }
}
