using System;

public enum Suit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public enum Rank
{
    Ace = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}

public class Card
{
    private Rank rank;
    private Suit suit;

    public Card(Suit suit, Rank rank)
    {
        this.suit = suit;
        this.rank = rank;
    }

    public Rank GetRank()
    {
        return rank;
    }

    public Suit GetSuit()
    {
        return suit;
    }

    // 🔥 FIXED HERE
    public override string ToString()
    {
        return $"{(int)rank} of {suit}";
    }
}
