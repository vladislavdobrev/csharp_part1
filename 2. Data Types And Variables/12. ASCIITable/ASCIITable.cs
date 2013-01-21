using System;

class ASCIITable
{
    static void Main()
    {
        byte ascii = 0;
        Console.WriteLine("Dec\t|\tHex\t|\tChar\n\n");
        for (ascii = 0; ascii <= sbyte.MaxValue; ascii++)
        {
            Console.WriteLine("{0}\t|\t{1}\t|\t{2}", ascii, ascii.ToString("X"), Convert.ToChar(ascii));
        }
    }
}
