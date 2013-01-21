using System;

class Lines
{
    static void Main()
    {
        char[,] n = new char[8, 8];

        for (int i = 0; i < 8; i++)
        {
            byte m = byte.Parse(Console.ReadLine());
            string strM = Convert.ToString(m, 2).PadLeft(8, '0');

            for (int k = 0; k < 8; k++)
            {
                n[i, k] = strM[k];
            }
        }

        int counterX = 0;
        int biggestX = 0;
        int counterY = 0;
        int biggestY = 0;
        int checker = 0;

        for (int i = 0; i < 8; i++)
        {
            checker = 0;
            for (int j = 0; j < 8; j++)
            {
                if (n[i, j] == '1')
                {
                    checker++;

                    if (checker > biggestX)
                    {
                        biggestX = checker;
                        counterX = 1;
                    }
                    else if (checker == biggestX)
                    {
                        counterX++;
                    }
                }
                else
                {
                    checker = 0;
                }
            }
        }

        for (int i = 0; i < 8; i++)
        {
            checker = 0;
            for (int j = 0; j < 8; j++)
            {
                if (n[j, i] == '1')
                {
                    checker++;

                    if (checker > biggestY)
                    {
                        biggestY = checker;
                        counterY = 1;
                    }
                    else if (checker == biggestY)
                    {
                        counterY++;
                    }
                }
                else
                {
                    checker = 0;
                }
            }
        }

        if (biggestX == 1 && biggestY == 1)
        {
            Console.WriteLine(biggestX);
            Console.WriteLine(counterX);
        }
        else
        {
            if (biggestX == biggestY)
            {
                Console.WriteLine(biggestX);
                Console.WriteLine(counterX + counterY);
            }
            else if (biggestX > biggestY)
            {
                Console.WriteLine(biggestX);
                Console.WriteLine(counterX);
            }
            else
            {
                Console.WriteLine(biggestY);
                Console.WriteLine(counterY);
            }
        }
    }
}
