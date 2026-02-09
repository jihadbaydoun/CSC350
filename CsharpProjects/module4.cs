/*string[] fraudulentOrderIDs = new string[3];  ### this how i declarte array of dting with 3 elements, 0,1,2


string[] names = { "jihad", "lewii", "Brahim" };  # this how in do lloop
foreach (string name in names)
{
    Console.WriteLine(name);
}

//


int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

*/
// Create an array of order IDs
string[] orderIDs =
{
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

//               #@####     Loop through each order ID in the array
foreach (string order in orderIDs)
{
    // ####    Check if the current order starts with the letter "B"
    if (order.StartsWith("B"))
    {
        // #####      If true, print the order ID to the console
        Console.WriteLine(order);
    }
}