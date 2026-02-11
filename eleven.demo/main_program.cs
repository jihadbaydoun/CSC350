using System;

class Program
{
    static void Main()
    {
        GameController game = new GameController();

        while (true)
        {
            var cards = game.GetTableCards();

            Console.WriteLine("\nCurrent Table:");
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine($"{i}: {cards[i]}");
            }

            Console.WriteLine("\nEnter two indexes separated by space (or 'q' to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            string[] parts = input.Split(' ');

            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (int.TryParse(parts[0], out int i1) &&
                int.TryParse(parts[1], out int i2))
            {
                bool success = game.TryPlay(i1, i2);

                if (success)
                    Console.WriteLine("Valid move! Cards removed.");
                else
                    Console.WriteLine("Invalid move.");
            }
            else
            {
                Console.WriteLine("Invalid numbers.");
            }
        }

        Console.WriteLine("Game ended.");
    }
}
