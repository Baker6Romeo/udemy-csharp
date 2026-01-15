int firstNumber;
int secondNumber;
string symbol;
int total;

Console.WriteLine("Hello, Chum!");
AskForFirstNumber();
AskForSecondNumber();
AskForOperator();
CalculateTotal();
PrintAnswer();

void AskForFirstNumber()
{  
  bool isValid;
  do
  {
    Console.WriteLine("Input your first number:");
    string input = Console.ReadLine();
    isValid = int.TryParse(input, out firstNumber);
  } while (!isValid);
}

void AskForSecondNumber()
{bool isValid;
  do
  {
    Console.WriteLine("Input your second number:");
    string input = Console.ReadLine();
    isValid = int.TryParse(input, out secondNumber);
  } while (!isValid);
}

void AskForOperator()
{
  bool isValidOperator = false;
  do{
  Console.WriteLine("What do you want to do?");
  Console.WriteLine("[A]dd numbers");
  Console.WriteLine("[S]ubtract numbers");
  Console.WriteLine("[M]ultiply numbers");
  
  symbol = Console.ReadLine().ToLower();
  if (symbol == "a" || symbol == "s" || symbol == "m")
    {
      isValidOperator = true;
    } else
    {
      Console.WriteLine("Entry is invalid. Try again.");
    }
  } while (!isValidOperator);
}

void CalculateTotal()
{
  if (symbol == "a")
  {
    total = firstNumber + secondNumber;
    symbol = "+";
  } else if (symbol == "s")
  {
    total = firstNumber - secondNumber;
    symbol = "-";
  } else if (symbol == "m")
  {
    total = firstNumber * secondNumber;
    symbol = "*";
  } else
  {
    total = 0;
  }
}

void PrintAnswer()
{
  Console.WriteLine($"{firstNumber} {symbol} {secondNumber} = {total}");
}
