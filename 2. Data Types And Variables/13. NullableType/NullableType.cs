using System;

class NullableType
{
    static void Main()
    {
        int? var1 = null;
        double? var2 = null;
        Console.WriteLine("Nullable variables: int var = {0}; double var = {1}", var1, var2);

        var1 += 5;
        var2 += 5.555d;
        Console.WriteLine("Nullable variables: int var = {0}; double var = {1}", var1, var2);
    }
}
