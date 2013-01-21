using System;

class DeckOfCards
{
    static void Main()
    {
        // 0 = clubs; 1 = diamonds; 2 = hearts; 3 = spades
        // 0 = Ace; 1 = 2; 2 = 3 ... 11 = Jack; 12 = Queen; 13 = King

        string[] suits = 
        {
            " of clubs",
            " of diamonds",
            " of hearts",
            " of spades"
        };

        string[] cards = 
        {
            "Ace",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Queen",
            "King"
        };

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                Console.WriteLine(cards[j] + suits[i]);
            }
            Console.WriteLine();
        }
    }
}
