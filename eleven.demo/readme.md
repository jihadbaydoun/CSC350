This project is a console version of the Elevens card game written in C#. When the program starts, it creates a deck of 52 cards, shuffles it, and deals 9 cards onto the table. The user can then choose two cards by typing their index numbers. If the two selected cards add up to 11, they are removed and replaced with new cards from the deck. The game keeps running until the user types “q” to quit.

I used different classes to organize the code. The Card class represents a single card with a suit and a rank. The Deck class creates all 52 cards and handles shuffling and dealing. The Table class stores the cards that are currently visible to the player. The GameController class controls the game logic, like checking if a move is valid and updating the table. The main program just handles displaying the cards and asking the user for input.

This project helped me understand how to separate logic from input/output and how to use classes properly. I also learned how enums make the program safer by preventing invalid card values. Overall, the goal was to keep the code organized and clear while making a working interactive console game.

To run the program, go to the project folder and type:

dotnet run