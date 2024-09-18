using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Please provide two numbers for the calculations:");

string input1 = Console.ReadLine();
float a = Convert.ToSingle(input1);

string input2 = Console.ReadLine();
float b = Convert.ToSingle(input2);

double result = a / b;

Console.WriteLine("Your result as a float is " + result + " .");