using System;

class IsPointInCircle
{
    static void Main()
    {
        string x = null;
        string y = null;
        Console.Write("Enter width: ");
        x = Console.ReadLine();
        Console.Write("Enter height: ");
        y = Console.ReadLine();
        int intX = int.Parse(x);
        int intY = int.Parse(y);
        bool isInsideCirle = (intX - 0) * (intX - 0) + (intY - 0) * (intY - 0) < 5 * 5 ? true : false;
        Console.WriteLine("The point with X = {0} and Y = {1} is inside the cirle? {2}",
            intX, intY, isInsideCirle);
    }
}
