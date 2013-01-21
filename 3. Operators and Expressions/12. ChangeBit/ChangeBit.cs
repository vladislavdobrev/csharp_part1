using System;

class ChangeBit
{
    static void Main()
    {
        string number = null;
        string bit = null;
        string position = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        Console.Write("New bit?: ");
        bit = Console.ReadLine();
        int intBit = int.Parse(bit);
        Console.Write("Position?: ");
        position = Console.ReadLine();
        int intPosition = int.Parse(position);
        int mask = 1 << intPosition;
        int result = 0;
        if (intBit == 1)
        {
            result = intNumber | mask;
        }
        else
        {
            result = intNumber & (~mask);
        }
        Console.WriteLine("The bit {0} of a the number {1}[{2}] is changed to {3}\nand the new number is {4}[{5}]",
            intPosition, intNumber, Convert.ToString(intNumber, 2).PadLeft(32, '0'), 
            intBit, result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
