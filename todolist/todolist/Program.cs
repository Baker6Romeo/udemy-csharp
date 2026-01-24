// Console.WriteLine("Hello, Chum!");
// Console.WriteLine("What would you like to do?");
// Console.WriteLine("[S]ee all TODOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");

// string? userInput = Console.ReadLine().ToUpper();
// string output;
// switch (userInput)
// {
//   case "S":
//     output = "See all TODOs";
//     PrintSelectedOption(output);
//     break;
//   case "A":
//     output = "Add a TODO";
//     PrintSelectedOption(output);
//     break;
//   case "R":
//     output = "Remove TODO";
//     PrintSelectedOption(output);
//     break;
//   case "E":
//     output = "Exit";
//     PrintSelectedOption(output);
//     break;
//   default:
//     output = "Invalid Input";
//     PrintSelectedOption(output);
//     break;
// }

Console.WriteLine($"Points:10 , Grade: {EvaluateGrade(10)}");
Console.WriteLine($"Points:9 , Grade: {EvaluateGrade(9)}");
Console.WriteLine($"Points:8 , Grade: {EvaluateGrade(8)}");
Console.WriteLine($"Points:7 , Grade: {EvaluateGrade(7)}");
Console.WriteLine($"Points:6 , Grade: {EvaluateGrade(6)}");
Console.WriteLine($"Points:5 , Grade: {EvaluateGrade(5)}");
Console.WriteLine($"Points:4 , Grade: {EvaluateGrade(4)}");
Console.WriteLine($"Points:3 , Grade: {EvaluateGrade(3)}");
Console.WriteLine($"Points:2 , Grade: {EvaluateGrade(2)}");
Console.WriteLine($"Points:1 , Grade: {EvaluateGrade(1)}");
Console.WriteLine($"Points:0 , Grade: {EvaluateGrade(0)}");

Console.ReadKey();

static string EvaluateGrade(int points)
{
  int num = points;
  return points switch
  {
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    < 60 => "E"
  };
}

// static void PrintSelectedOption(string selectedOption)
// {
//   Console.WriteLine($"Selected option: {selectedOption}");
// }