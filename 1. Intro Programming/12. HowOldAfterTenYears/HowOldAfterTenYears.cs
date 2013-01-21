using System;

class HowOldAfterTenYears
{
    static void Main()
    {
        string age = null;
        Console.WriteLine("How old are you?");
        Console.Write(">> ");
        age = Console.ReadLine();
        Console.WriteLine("After 10 years you'll be {0} years old.", int.Parse(age) + 10);
    }
}
