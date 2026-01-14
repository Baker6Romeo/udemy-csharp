Console.WriteLine("Hello, Chum!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[E]xit");

string? userInput = Console.ReadLine();
Console.WriteLine($"User Input: {userInput}");

string? userChoice = Console.ReadLine();
if(userChoice.Length < 0)
{
  Console.WriteLine($"Non-empty choice: {userChoice}");
} else
{
  Console.WriteLine("Empty choice");
}
Console.WriteLine($"Your choice is: {userChoice}");

Console.ReadKey();