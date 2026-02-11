using System.Collections.Generic;

public class Table
{
    private List<Card> visibleCards;

    public Table()
    {
        visibleCards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        if (card != null && visibleCards.Count < 9)
        {
            visibleCards.Add(card);
        }
    }

    public void RemoveCards(List<Card> selected)
    {
        if (selected == null) return;

        foreach (Card card in selected)
        {
            visibleCards.Remove(card);
        }
    }

    public IReadOnlyList<Card> GetCards()
    {
        return visibleCards.AsReadOnly();
    }

    public int Count()
    {
        return visibleCards.Count;
    }
}
