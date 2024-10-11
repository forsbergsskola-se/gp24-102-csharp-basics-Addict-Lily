

Console.WriteLine("Enter your numbers for the calculation:");

double numb1 = double.Parse(Console.ReadLine());
string userInput = Console.ReadLine();
double numb2 = double.Parse(Console.ReadLine());
string plus = "+";
string result = "=";

double num1 = 0;
double num2 = 0;

if (userInput == "+")
{ 
    Console.WriteLine($"{result}{numb1 + numb2}");
}
else if (userInput == "-")
{
    Console.WriteLine($"{result}{numb1 - numb2}");
}
else if (userInput == "*")
{
    Console.WriteLine($"{result}{numb1 * numb2}");
}
else if (userInput == "/") 
{
    Console.WriteLine($"{result}{numb1 / numb2}");
}
