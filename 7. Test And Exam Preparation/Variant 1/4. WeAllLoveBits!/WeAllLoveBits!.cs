using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] intArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            intArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            string strN = Convert.ToString(intArr[i], 2);
            char[] charN = new char[strN.Length];

            int br = 0;
            for (int j = strN.Length - 1; j >= 0; j--)
            {
                charN[br] = strN[j];
                br++;
            }

            string strChar = new string(charN);

            Console.WriteLine(~0 & Convert.ToUInt32(strChar, 2));
        }
    }
}
