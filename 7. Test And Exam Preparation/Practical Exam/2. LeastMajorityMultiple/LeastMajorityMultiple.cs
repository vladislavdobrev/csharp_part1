using System;

class LeastMajorityMultiple
{
    static int MinNumber(byte[] a)
    {
        int smallest = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < smallest)
            {
                smallest = a[i];
            }
        }

        return smallest;
    }

    static void Main()
    {
        byte[] array = new byte[5];
        for (int i = 0; i < 5; i++)
        {
            array[i] = byte.Parse(Console.ReadLine());
        }

        int smallest = MinNumber(array);

        int result = smallest;
        bool end = false;
        while (!end)
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (result % array[i] == 0)
                {
                    count++;
                }
            }
            if (count >= 3)
            {
                end = true;
            }
            else
            {
                result += smallest;
            }
        }

        Console.WriteLine(result);
    }
}
