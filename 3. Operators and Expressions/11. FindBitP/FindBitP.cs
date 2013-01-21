using System;

class FindBitP
{
    static void Main()
    {
        string number = null;
        string bit = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        Console.Write("Check witch bit?: ");
        bit = Console.ReadLine();
        int intBit = int.Parse(bit);
        int mask = 1 << intBit;
        int result = intNumber & mask;
        result >>= intBit;
        Console.WriteLine("The bit {0} of a the number {1}[{2}] is {3}",
            intBit, intNumber, Convert.ToString(intNumber, 2).PadLeft(32, '0'), result);
    }
}
