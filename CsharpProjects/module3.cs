/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if (total > 14)            // here any num greater than 14 will be a win
{
    Console.WriteLine("You win!");
}

                if (total < 15)         /// here any num less than 15 will be a loss
{
    Console.WriteLine("Sorry, you lose.");
}

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
/
                    /////########this the third part
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Expiration message
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1) //If the user's subscription will expire in one day
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// Discount message (separate if statement)
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
