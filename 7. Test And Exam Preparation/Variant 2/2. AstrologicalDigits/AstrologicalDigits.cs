using System;
using System.Globalization;
using System.Threading;

class AstrologicalDigits
{
    static int AstrologicalDigit(string number, int sum = 0)
    {
        for (int i = 0; i < number.Length; i++)
        {
            byte digit;
            bool tryParse = byte.TryParse(number[i].ToString(), out digit);
            if (tryParse)
            {
                sum += digit;
            }
        }

        if (sum > 9)
        {
            sum = AstrologicalDigit(sum.ToString(), 0);
        }

        return sum;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string number = Console.ReadLine();
        int sum = AstrologicalDigit(number);
        Console.WriteLine(sum);
    }
}