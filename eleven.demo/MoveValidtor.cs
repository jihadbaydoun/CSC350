using System.Collections.Generic;
using System.Linq;

public class MoveValidator
{
    public bool IsValidSelection(IReadOnlyList<Card> selected)
    {
        if (selected.Count == 2)
            return IsValidPair(selected[0], selected[1]);

        if (selected.Count == 3)
            return IsValidTriple(selected);

        return false;
    }

    public bool IsValidPair(Card a, Card b)
    {
        return a.ValueForEleven + b.ValueForEleven == 11;
    }

    public bool IsValidTriple(IReadOnlyList<Card> three)
    {
        return three.Count == 3 &&
               three.Any(c => c.IsJack) &&
               three.Any(c => c.IsQueen) &&
               three.Any(c => c.IsKing);
    }

    public bool HasLegalMoves(IReadOnlyList<Card> tableCards)
    {
        // Check pairs
        for (int i = 0; i < tableCards.Count; i++)
        {
            for (int j = i + 1; j < tableCards.Count; j++)
            {
                if (IsValidPair(tableCards[i], tableCards[j]))
                    return true;
            }
        }

        // Check J-Q-K
        return tableCards.Any(c => c.IsJack) &&
               tableCards.Any(c => c.IsQueen) &&
               tableCards.Any(c => c.IsKing);
    }
}