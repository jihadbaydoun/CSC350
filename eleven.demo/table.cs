using System;
using System.Collections.Generic;


/// Represents the table in the Elevens game.
/// The table holds the visible cards that the player can interact with.
/// It does NOT contain game rules or validation logic.


    // Stores the cards currently visible on the table (maximum of 9)
    private List<Card> visibleCards;

  
    /// Constructs an empty table.
    /// Cards are added later by the GameController.
  
    public Table()
    {
        visibleCards = new List<Card>();
    }


    /// Adds a card to the table if there is space.
    /// This method is typically used when dealing or replacing cards.
    
    /// <param name="card">The card to add to the table</param>
    public void AddCard(Card card)
    {
        // Ensure the card is valid and the table does not exceed 9 cards
        if (card != null && visibleCards.Count < 9)
        {
            visibleCards.Add(card);
        }
    }

    
    /// Removes the selected cards from the table.
    /// Assumes the selection has already been validated by the GameController.
    
    public void RemoveCards(List<Card> selected)
    {
        // Remove each selected card from the visible cards
        foreach (Card card in selected)
        {
            visibleCards.Remove(card);
        }
    }

    /// <summary>
    /// Returns the list of cards currently on the table.
    /// Used by the GameController to display or evaluate the game state.
    /// </summary>
    /// <returns>List of visible cards</returns>
    public List<Card> GetCards()
    {
        return visibleCards;
    }
}
