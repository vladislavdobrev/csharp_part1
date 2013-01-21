using System;

class ChooseFloat
{
    static void Main()
    {
        double var1 = 34.567839023d;
        float var2 = 12.345f;
        double var3 = 8923.1234857d;
        float var4 = 3456.091f;

        Console.WriteLine("Var1: type = {0}; value = {1}", var1.GetTypeCode(), var1);
        Console.WriteLine("Var2: type = {0}; value = {1}", var2.GetTypeCode(), var2);
        Console.WriteLine("Var3: type = {0}; value = {1}", var3.GetTypeCode(), var3);
        Console.WriteLine("Var4: type = {0}; value = {1}", var4.GetTypeCode(), var4);
    }
}
