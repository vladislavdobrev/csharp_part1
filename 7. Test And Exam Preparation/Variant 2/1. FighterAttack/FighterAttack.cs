using System;
using System.Globalization;
using System.Threading;

class FighterAttack
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int px1, px2, py1, py2, fx, fy, d;

        px1 = int.Parse(Console.ReadLine());
        py1 = int.Parse(Console.ReadLine());
        px2 = int.Parse(Console.ReadLine());
        py2 = int.Parse(Console.ReadLine());
        fx = int.Parse(Console.ReadLine());
        fy = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());

        fx += d;

        int result = 0;
        if (px1 > px2)
        {
            if (py1 > py2)
            {
                if (fx >= px2 && fx <= px1 && fy >= py2 && fy <= py1)
                {
                    result += 100;
                }
                if ((fx + 1) >= px2 && (fx + 1) <= px1 && fy >= py2 && fy <= py1)
                {
                    result += 75;
                }
                if (fx >= px2 && fx <= px1 && (fy + 1) >= py2 && (fy + 1) <= py1)
                {
                    result += 50;
                }
                if (fx >= px2 && fx <= px1 && (fy - 1) >= py2 && (fy - 1) <= py1)
                {
                    result += 50;
                }
            }
            else
            {
                if (fx >= px2 && fx <= px1 && fy >= py1 && fy <= py2)
                {
                    result += 100;
                }
                if ((fx + 1) >= px2 && (fx + 1) <= px1 && fy >= py1 && fy <= py2)
                {
                    result += 75;
                }
                if (fx >= px2 && fx <= px1 && (fy + 1) >= py1 && (fy + 1) <= py2)
                {
                    result += 50;
                }
                if (fx >= px2 && fx <= px1 && (fy - 1) >= py1 && (fy - 1) <= py2)
                {
                    result += 50;
                }
            }
        }
        else
        {
            if (py1 > py2)
            {
                if (fx >= px1 && fx <= px2 && fy >= py2 && fy <= py1)
                {
                    result += 100;
                }
                if ((fx + 1) >= px1 && (fx + 1) <= px2 && fy >= py2 && fy <= py1)
                {
                    result += 75;
                }
                if (fx >= px1 && fx <= px2 && (fy + 1) >= py2 && (fy + 1) <= py1)
                {
                    result += 50;
                }
                if (fx >= px1 && fx <= px2 && (fy - 1) >= py2 && (fy - 1) <= py1)
                {
                    result += 50;
                }
            }
            else
            {
                if (fx >= px1 && fx <= px2 && fy >= py1 && fy <= py2)
                {
                    result += 100;
                }
                if ((fx + 1) >= px1 && (fx + 1) <= px2 && fy >= py1 && fy <= py2)
                {
                    result += 75;
                }
                if (fx >= px1 && fx <= px2 && (fy + 1) >= py1 && (fy + 1) <= py2)
                {
                    result += 50;
                }
                if (fx >= px1 && fx <= px2 && (fy - 1) >= py1 && (fy - 1) <= py2)
                {
                    result += 50;
                }
            }
        }

        Console.WriteLine(result + "%");
    }
}
