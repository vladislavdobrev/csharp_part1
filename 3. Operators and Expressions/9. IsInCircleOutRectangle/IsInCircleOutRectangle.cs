using System;
using System.Drawing;

class IsInCircleOutRectangle
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
        Rectangle rect = new Rectangle(1, -1, 6, 2);
        bool isInCirleAndOutRectangle = ((intX - 1) * (intX - 1) + (intY - 1) * (intY - 1) < 3 * 3) 
            && !rect.Contains(intX, intY) ? true : false;
        Console.WriteLine("The point [{0}; {1}] is inside the cirle and outside the rectangle? {2}",
            intX, intY, isInCirleAndOutRectangle);
    }
}
