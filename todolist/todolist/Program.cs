Console.WriteLine("Hello, Chum!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string? userInput = Console.ReadLine();

if(userInput == "S")
{
  Console.WriteLine("See all TODOs");
} else if (userInput == "A")
{
  Console.WriteLine("Add a TODO");
} else if (userInput == "E")
{
  Console.WriteLine("Exit");
} else if (userInput == "R")
{
  Console.WriteLine("Remove TODO");
} else 
{
  Console.WriteLine("Invalid Input");
}

Console.ReadKey();