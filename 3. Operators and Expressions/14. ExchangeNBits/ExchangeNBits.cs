using System;

class ExchangeNBits
{
    static void Main()
    {
        string number = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        uint intNumber = uint.Parse(number);

        string exchangeCount = null;
        Console.Write("How much exchanges do want to do? ");
        exchangeCount = Console.ReadLine();
        int intExchanges = int.Parse(exchangeCount);

        Console.WriteLine("\nOriginal:\t{0}\t{1}\n", intNumber, Convert.ToString(intNumber, 2).PadLeft(32, '0'));
        for (int i = 1; i <= intExchanges; i++)
        {
            string firstBit = null;
            string secondBit = null;
            Console.Write("What is the position of the bit number 1: ");
            firstBit = Console.ReadLine();
            int firstPosition = int.Parse(firstBit);
            Console.Write("What is the position of the bit number 2: ");
            secondBit = Console.ReadLine();
            int secondPosition = int.Parse(secondBit);

            if (firstPosition != secondPosition)
            {
                int mask1 = 1 << firstPosition;
                uint result1 = intNumber & (uint)mask1;
                result1 >>= firstPosition;
                int mask2 = 1 << secondPosition;
                uint result2 = intNumber & (uint)mask2;
                result2 >>= secondPosition;
                if (result2 == 1)
                {
                    intNumber |= (uint)mask1;
                }
                else
                {
                    intNumber &= (~(uint)mask1);
                }
                if (result1 == 1)
                {
                    intNumber |= (uint)mask2;
                }
                else
                {
                    intNumber &= (~(uint)mask2);
                }
            }

            Console.WriteLine("\nAfter step {0}:\t{1}\t{2}\n", i, intNumber, Convert.ToString(intNumber, 2).PadLeft(32, '0'));
        }
    }
}
