using System;
using System.Collections.Generic;

public class GameController
{
    private Deck deck;
    private Table table;
    private bool gameRunning;

    public GameController()
    {
        deck = new Deck();
        table = new Table();
        gameRunning = false;
    }

    public void StartGame()
    {
        deck.Shuffle();
        DealInitialCards();
        gameRunning = true;
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

    public bool SubmitSelection(int index1, int index2)
    {
        if (!ValidateSelection(index1, index2))
            return false;

        var cards = table.GetCards();

        Card card1 = cards[index1];
        Card card2 = cards[index2];

        table.RemoveCards(new List<Card> { card1, card2 });

        if (!deck.IsEmpty())
            table.AddCard(deck.Deal());

        if (!deck.IsEmpty())
            table.AddCard(deck.Deal());

        return true;
    }

    public bool ValidateSelection(int index1, int index2)
    {
        var cards = table.GetCards();

        if (index1 < 0 || index1 >= cards.Count ||
            index2 < 0 || index2 >= cards.Count ||
            index1 == index2)
        {
            return false;
        }

        int value1 = (int)cards[index1].GetRank();
        int value2 = (int)cards[index2].GetRank();

        return value1 + value2 == 11;
    }

    public void PlayTurn(int index1, int index2)
    {
        SubmitSelection(index1, index2);
    }

    public bool CheckEndState()
    {
        return deck.IsEmpty();
    }

    public void EndGame()
    {
        gameRunning = false;
        Console.WriteLine("Game Over.");
    }

    public IReadOnlyList<Card> GetTableCards()
    {
        return table.GetCards();
    }
}
