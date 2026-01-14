Console.WriteLine("Hello, Chum!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string? userInput = Console.ReadLine();
string output;
if(userInput == "S")
{
  output = "See all TODOs";
  PrintSelectedOption(output);
} else if (userInput == "A")
{
  output = "Add a TODO";
  PrintSelectedOption(output);
} else if (userInput == "E")
{
  output = "Exit";
  PrintSelectedOption(output);
} else if (userInput == "R")
{
  output = "Remove TODO";
  PrintSelectedOption(output);
} else 
{
  output = "Invalid Input";
  PrintSelectedOption(output);
}

Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
  Console.WriteLine($"Selected option: {selectedOption}");
}