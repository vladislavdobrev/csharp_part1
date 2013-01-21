using System;

class Pillars
{
    static void Main()
    {
        int count = 0;
        int[] intArr = new int[8];
        for (int i = 0; i < 8; i++)
        {
            string number = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            for (int j = 0; j < 8; j++)
            {
                if (number[j] == '1')
                {
                    intArr[j]++;
                    count++;
                }
            }
        }

        int temp = 0;
        bool flag = true;
        for (int i = 0; i < 8; i++)
        {
            if (count - intArr[i] == temp * 2)
            {
                Console.WriteLine(7 - i);
                Console.WriteLine(temp);
                flag = false;
                break;
            }
            temp += intArr[i];
        }
        if (flag)
        {
            Console.WriteLine("No");
        }
    }
}
