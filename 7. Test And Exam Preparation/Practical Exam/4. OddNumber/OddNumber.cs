using System;
using System.Collections.Generic;

class OddNumber
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Dictionary<decimal, int> arrayDict = new Dictionary<decimal,int>();

        for (int i = 0; i < N; i++)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            if (!arrayDict.ContainsKey(num))
            {
                arrayDict.Add(num, 1);
            }
            else
            {
                arrayDict[num]++;
            }
        }

        foreach (var item in arrayDict)
        {
            if (item.Value % 2 == 1)
            {
                Console.WriteLine(item.Key);
                break;
            }
        }
    }
}
