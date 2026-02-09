//className.methodMtetode();        that how you call a method in c#


/*
Console.WriteLine("Hello, c#!");

Random dice = new Random();  //ClassName   objectName = new ClassName();
int roll = dice.Next(1,7);
Console.WriteLine(roll);


int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine("The number is ");
Console.WriteLine(text);

*/
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");