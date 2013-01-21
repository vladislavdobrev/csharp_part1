using System;
using System.Collections.Generic;

class NumbersToWords
{
    static string NumberToWord(int number)
    {
        if (number == 0)
        {
            return "Zero";
        }

        string name = null;

        if (number / 100 > 0)
        {
            name += NumberToWord(number / 100) + " hundred";
            number %= 100;
        }

        if (number > 0)
        {
            if (name != null)
            {
                name += " and ";
            }

            Dictionary<int, string> constNumbers = new Dictionary<int, string>();
            constNumbers.Add(0, "zero");
            constNumbers.Add(1, "one");
            constNumbers.Add(2, "two");
            constNumbers.Add(3, "three");
            constNumbers.Add(4, "four");
            constNumbers.Add(5, "five");
            constNumbers.Add(6, "six");
            constNumbers.Add(7, "seven");
            constNumbers.Add(8, "eight");
            constNumbers.Add(9, "nine");
            constNumbers.Add(10, "ten");
            constNumbers.Add(11, "eleven");
            constNumbers.Add(12, "twelve");
            constNumbers.Add(13, "thirteen");
            constNumbers.Add(14, "fourteen");
            constNumbers.Add(15, "fifteen");
            constNumbers.Add(16, "sixteen");
            constNumbers.Add(17, "seventeen");
            constNumbers.Add(18, "eighteen");
            constNumbers.Add(19, "nineteen");
            constNumbers.Add(20, "twenty");
            constNumbers.Add(30, "thirty");
            constNumbers.Add(40, "fourty");
            constNumbers.Add(50, "fifty");
            constNumbers.Add(60, "sixty");
            constNumbers.Add(70, "seventy");
            constNumbers.Add(80, "eighty");
            constNumbers.Add(90, "ninety");

            if (constNumbers.ContainsKey(number))
            {
                name += constNumbers[number];
            }
            else
            {
                name += constNumbers[(number / 10) * 10];
                if (number % 10 > 0)
                {
                    name += " " + constNumbers[number % 10];
                }
            }
        }
        return name;
    }

    static void Main()
    {
        int number;
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        string strNumber = NumberToWord(number);
        strNumber = strNumber[0].ToString().ToUpper() + strNumber.Substring(1);
        Console.WriteLine(strNumber);
    }
}
