using System;

class MissCat2011
{
    static void Main()
    {
        int n, vote;
        int[] votes = new int[10];
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            vote = int.Parse(Console.ReadLine());
            votes[vote - 1]++;
        }

        int biggest = votes[0];
        int theNumber = 1;
        for (int i = 0; i < 10; i++)
        {
            if (votes[i] > biggest)
            {
                biggest = votes[i];
                theNumber = i + 1;
            }
        }

        Console.WriteLine(theNumber);
    }
}