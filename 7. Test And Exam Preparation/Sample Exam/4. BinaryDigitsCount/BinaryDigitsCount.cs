using System;

class BinaryDigitsCount
{
    static void Main()
    {
        byte b = byte.Parse(Console.ReadLine());
        short n = short.Parse(Console.ReadLine());
        int[] counts = new int[n];
        for (int i = 0; i < n; i++)
        {
            uint number = uint.Parse(Console.ReadLine());
            string strNumber = Convert.ToString(number, 2);
            int count = strNumber.Length - strNumber.Replace(b.ToString(), "").Length;
            counts[i] = count;
        }

        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(counts[j]);
        }
    }
}