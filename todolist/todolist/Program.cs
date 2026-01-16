Console.WriteLine("Hello, Chum!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string? userInput = Console.ReadLine().ToUpper();
string output;
switch (userInput)
{
  case "S":
    output = "See all TODOs";
    PrintSelectedOption(output);
    break;
  case "A":
    output = "Add a TODO";
    PrintSelectedOption(output);
    break;
  case "R":
    output = "Remove TODO";
    PrintSelectedOption(output);
    break;
  case "E":
    output = "Exit";
    PrintSelectedOption(output);
    break;
  default:
    output = "Invalid Input";
    PrintSelectedOption(output);
    break;
}

Console.ReadKey();

static void PrintSelectedOption(string selectedOption)
{
  Console.WriteLine($"Selected option: {selectedOption}");
}