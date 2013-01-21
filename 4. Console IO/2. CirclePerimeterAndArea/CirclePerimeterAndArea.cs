using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        string r = null;
        Console.Write("Circle's R: ");
        r = Console.ReadLine();
        int intR = int.Parse(r);
        Console.WriteLine("Perimeter = {0}\nArea = {1}",
            2 * Math.PI * intR, Math.PI * intR * intR);
    }
}
