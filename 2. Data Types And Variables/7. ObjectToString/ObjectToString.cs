using System;
using System.Collections.Generic;

class ObjectToString
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concat = hello + " " + world;
        string converted = (string)concat;
        Console.WriteLine(converted);
    }
}
