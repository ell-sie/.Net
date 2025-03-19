// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, C#!");

// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// first code challenge

// int firstValue = 500;
// int secondValue = 600;

// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// if (total > 14)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here
// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage = 20}%!");
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage = 10}%!");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "E111";

// foreach (string orderID in fraudulentOrderIDs) {
//     Console.WriteLine(orderID);
// }

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


// int[] inventory = [200, 450, 700, 175, 250];

// int sum = 0;

// foreach (int items in inventory)
// {
//     sum += items;
// }

// Console.WriteLine(sum);

// string[] elements = ["B123", "C234", "A345", "C15", "B177", "G3003", "B179"];

// foreach (string element in elements) {
//     if (element.StartsWith("B")) {
//         Console.WriteLine(element);
//     }
// }

// int x = 5;

// if (x > 0) {
//     int y = 6;
//     x = x + y;
// }

// Console.WriteLine(x);

// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// int total = 0;
// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//     {
//         Console.WriteLine("Set contains 42");
//     }


// }

// Console.WriteLine($"Total: {total}");

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// Local function to print details
void Print(string name, string number = "", bool member = false)
{
	Console.WriteLine($"Name: {name}, Number: {number}, Member: {member}");
}

// Example usage of the Print function
Print("John Doe", "12345", true);