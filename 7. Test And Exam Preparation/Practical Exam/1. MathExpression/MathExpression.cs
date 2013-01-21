using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double N, M, P;

        N = double.Parse(Console.ReadLine());
        M = double.Parse(Console.ReadLine());
        P = double.Parse(Console.ReadLine());

        int mod = (int)M % 180;
        double expr = ((((N * N) + (1 / (M * P)) + 1337)) / (N - (128.523123123 * P))) + Math.Sin(mod);

        Console.WriteLine("{0:f6}", expr);
    }
}
