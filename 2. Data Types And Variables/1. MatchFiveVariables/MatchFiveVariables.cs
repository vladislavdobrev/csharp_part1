using System;

class MatchFiveVariables
{
    static void Main()
    {
        ushort var1 = 52130;
        sbyte var2 = -115;
        int var3 = 4825932;
        byte var4 = 97;
        short var5 = -10000;
        Console.WriteLine("Var1: type = {0}; value = {1}", var1.GetTypeCode(), var1);
        Console.WriteLine("Var2: type = {0}; value = {1}", var2.GetTypeCode(), var2);
        Console.WriteLine("Var3: type = {0}; value = {1}", var3.GetTypeCode(), var3);
        Console.WriteLine("Var4: type = {0}; value = {1}", var4.GetTypeCode(), var4);
        Console.WriteLine("Var5: type = {0}; value = {1}", var5.GetTypeCode(), var5);
    }
}
