using System;
using System.Globalization;
using System.Threading;

class DependOnChoice
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int a;
        double b;
        string something;
        Console.Write("Enter something(int, double, string): ");
        something = Console.ReadLine();
        bool isInt = int.TryParse(something, out a);
        bool isDouble = double.TryParse(something, out b);

        switch (isInt)
        {
            case true:
                a++;
                Console.WriteLine(a);
                break;
            case false:
                switch (isDouble)
                {
                    case true:
                        b++;
                        Console.WriteLine(b);
                        break;
                    case false:
                        something += "*";
                        Console.WriteLine(something);
                        break;
                }
                break;
        }
    }
}
