using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards;
    private Random random = new Random();

    public Deck()
    {
        cards = new List<Card>();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(new Card(suit, rank));
            }
        }
    }

    public void Shuffle()
    {
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);

            Card temp = cards[i];
            cards[i] = cards[j];
            cards[j] = temp;
        }
    }

    public Card Deal()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Deck is empty.");

        Card topCard = cards[0];
        cards.RemoveAt(0);
        return topCard;
    }

    public bool IsEmpty()
    {
        return cards.Count == 0;
    }

    public int Size()
    {
        return cards.Count;
    }
}
