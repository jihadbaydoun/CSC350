//className.methodMtetode();        that how you call a method in c#



Console.WriteLine("Hello, c#!");
                 //###### part 1 of the module ######
Random dice = new Random();  //ClassName   objectName = new ClassName();
int roll = dice.Next(1,7);
Console.WriteLine(roll);

                    //##### part 2 of the module ######
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine("The number is ");
Console.WriteLine(text);

                        //###### part 3 of the module ######
//Random dice = new Random();  // i put this one a comment because would run since we alresady declared it berfore
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = System.Math.Max(firstValue, secondValue);


Console.WriteLine(largerValue);                   