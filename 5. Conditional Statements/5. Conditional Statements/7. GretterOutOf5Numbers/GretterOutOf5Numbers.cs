using System;

class GretterOutOf5Numbers
{
    static void Main()
    {
        int a, b, c, d, e;
        Console.Write("Enter first number: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        c = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        d = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        e = int.Parse(Console.ReadLine());

        int biggest = a;
        if (b >= biggest)
        {
            if (b >= c)
            {
                if (b >= d)
                {
                    if (b >= e)
                    {
                        biggest = b;
                    }
                    else
                    {
                        biggest = e;
                    }
                }
                else
                {
                    if (d >= e)
                    {
                        biggest = d;
                    }
                    else
                    {
                        biggest = e;
                    }
                }
            }
            else
            {
                if (c >= d)
                {
                    if (c >= e)
                    {
                        biggest = c;
                    }
                    else
                    {
                        biggest = e;
                    }
                }
                else
                {
                    if (d >= e)
                    {
                        biggest = d;
                    }
                    else
                    {
                        biggest = e;
                    }
                }
            }
        }
        else
        {
            if (c >= biggest)
            {
                if (c >= d)
                {
                    if (c >= e)
                    {
                        biggest = c;
                    }
                    else
                    {
                        biggest = e;
                    }
                }
                else
                {
                    if (d >= e)
                    {
                        biggest = d;
                    }
                    else
                    {
                        biggest = e;
                    }
                }
            }
            else
            {
                if (d >= biggest)
                {
                    if (d >= e)
                    {
                        biggest = d;
                    }
                    else
                    {
                        biggest = e;
                    }
                }
                else
                {
                    if (e >= biggest)
                    {
                        biggest = e;
                    }
                }
            }
        }
        Console.WriteLine("The biggest of the numbers is {0}", biggest);
    }
}
