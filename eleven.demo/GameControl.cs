using System;
using System.Collections.Generic;

public class GameController
{
    private Deck deck;
    private Table table;

    public GameController()
    {
        deck = new Deck();
        table = new Table();

        deck.Shuffle();
        DealInitialCards();
    }

    private void DealInitialCards()
    {
        for (int i = 0; i < 9; i++)
        {
            if (!deck.IsEmpty())
            {
                table.AddCard(deck.Deal());
            }
        }
    }

    public IReadOnlyList<Card> GetTableCards()
    {
        return table.GetCards();
    }

    // 🔥 NEW METHOD ADDED HERE
    public bool TryPlay(int index1, int index2)
    {
        var cards = table.GetCards();

        if (index1 < 0 || index1 >= cards.Count ||
            index2 < 0 || index2 >= cards.Count ||
            index1 == index2)
        {
            return false;
        }

        Card card1 = cards[index1];
        Card card2 = cards[index2];

        int value1 = (int)card1.GetRank();
        int value2 = (int)card2.GetRank();

        if (value1 + value2 == 11)
        {
            table.RemoveCards(new List<Card> { card1, card2 });

            if (!deck.IsEmpty())
                table.AddCard(deck.Deal());

            if (!deck.IsEmpty())
                table.AddCard(deck.Deal());

            return true;
        }

        return false;
    }
}
