using System;

class SpyralMatrix
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        bool left = false;
        bool right = true;
        bool up = false;
        bool down = false;

        int loopLenght = n;
        int countLoop = 1;

        int counter = 1;

        int lastX = 0;
        int lastY = -1;

        int[,] spiral = new int[n, n];
        int temp = 1;
        while (temp <= 2 * n - 1)
        {
            if (right)
            {
                int constanta = lastY + 1;
                for (int i = constanta; i <= loopLenght + constanta - 1; i++)
                {
                    spiral[lastX, i] = counter;
                    counter++;
                    lastY++;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }
            else if (down)
            {
                int constanta = lastX + 1;
                for (int i = constanta; i <= loopLenght + constanta - 1; i++)
                {
                    spiral[i, lastY] = counter;
                    counter++;
                    lastX++;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }
            else if (left)
            {
                int constanta = lastY - 1;
                for (int i = constanta; i >= constanta - loopLenght + 1; i--)
                {
                    spiral[lastX, i] = counter;
                    counter++;
                    lastY--;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }
            else if (up)
            {
                int constanta = lastX - 1;
                for (int i = constanta; i >= constanta - loopLenght + 1; i--)
                {
                    spiral[i, lastY] = counter;
                    counter++;
                    lastX--;
                }

                countLoop++;
                if (countLoop % 2 == 0)
                {
                    loopLenght--;
                }
            }

            if (right)
            {
                right = false;
                down = true;
            }
            else if (down)
            {
                down = false;
                left = true;
            }
            else if (left)
            {
                left = false;
                up = true;
            }
            else if (up)
            {
                up = false;
                right = true;
            }

            temp++;
        }

        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiral[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
