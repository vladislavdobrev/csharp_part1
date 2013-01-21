using System;

class Program
{
    static void Main()
    {
        int k, n;
        k = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        string textNumber = null;
        for (int i = 0; i < n; i++)
        {
            uint number = uint.Parse(Console.ReadLine());
            textNumber += Convert.ToString(number, 2);
        }

        string searchOnes = "0".PadRight(k + 1, '1') + "0";
        string searchZeroes = "1".PadRight(k + 1, '0') + "1";

        if (textNumber[0] == '1')
        {
            textNumber = '0' + textNumber;
        }
        else
        {
            textNumber = '1' + textNumber;
        }

        if (textNumber[textNumber.Length - 1] == '1')
        {
            textNumber += '0';
        }
        else
        {
            textNumber += '1';
        }

        int count = 0;
        for (int i = 0; i <= textNumber.Length - searchOnes.Length; i++)
        {
            string item = textNumber.Substring(i, searchOnes.Length);
            if (item == searchOnes || item == searchZeroes)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
