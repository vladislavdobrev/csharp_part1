using System;

class FallDown
{
    static void Main()
    {
        char[,] numbers = new char[8,8];
        for (int i = 0; i < 8; i++)
        {
            byte num = byte.Parse(Console.ReadLine());
            string strNum = Convert.ToString(num, 2).PadLeft(8, '0');
            for (int j = 0; j < 8; j++)
            {
                numbers[i, j] = strNum[j];
            }
        }

        for (int i = 0; i < 8; i++)
        {
            int count = 0;
            for (int j = 0; j < 8; j++)
            {
                if (numbers[j, i] == '1')
                {
                    count++;
                    numbers[j, i] = '0';
                }
            }

            for (int k = 8 - count; k < 8; k++)
            {
                numbers[k, i] = '1';
            }
        }

        for (int i = 0; i < 8; i++)
        {
            string theNum = null;
            for (int j = 0; j < 8; j++)
            {
                theNum += numbers[i, j];
            }
            Console.WriteLine(Convert.ToUInt32(theNum, 2));
        }
    }
}
