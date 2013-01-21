using System;

class RectangleArea
{
    static void Main()
    {
        string width = null;
        string height = null;
        Console.Write("Enter width: ");
        width = Console.ReadLine();
        Console.Write("Enter height: ");
        height = Console.ReadLine();
        int intWidth = int.Parse(width);
        int intHeight = int.Parse(height);
        Console.WriteLine("Rectangle's area is {0}", intWidth * intHeight);
    }
}
