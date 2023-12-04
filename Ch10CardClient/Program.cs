using System;
using static System.Console;
using Ch10CardLib;

namespace Ch10CardClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Deck playDeck = new();
                playDeck.Shuffle();
                bool isFlush = false;
                int flushHandIndex = 0;
                for (int hand = 0; hand < 10; hand++)
                {
                    isFlush = true;
                    Suit flushSuit = playDeck.GetCard(hand * 5).suit;
                    for (int card = 1; card < 5; card++)
                    {
                        if (playDeck.GetCard(hand * 5 + card).suit != flushSuit)
                        {
                            isFlush = false;
                            break;
                        }
                    }
                    if (isFlush)
                    {
                        WriteLine("Flush!");
                        for (int card = 0; card < 5; card++)
                        {
                            WriteLine(playDeck.GetCard(flushHandIndex + card));
                        }
                    }
                    else
                    {
                        WriteLine("No flush.");
                    }
                    ReadLine();
                }
            }
        }
    }
}
