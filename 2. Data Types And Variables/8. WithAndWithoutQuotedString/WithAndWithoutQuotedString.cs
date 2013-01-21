using System;

class WithAndWithoutQuotedString
{
    static void Main()
    {
        string quotedString = "The \"use\" of quotations causes difficulties.";
        string notQuotedString = @"The ""use"" of quotations causes difficulties.";
        Console.Write("Quoted String: {0}\nNot Quoted String: {1}\n", quotedString, notQuotedString);
    }
}
