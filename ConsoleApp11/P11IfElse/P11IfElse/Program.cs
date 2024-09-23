/*Console.WriteLine("How old are you?");
string userInput = Console.ReadLine();

int grades = int.Parse(userInput);

bool isChild = grades >= 0 && grades <= 12;
Console.WriteLine($"You are a child: {isChild}");

bool isTeenager = grades >= 13 && grades < 19;
Console.WriteLine($"You are a teenager: {isTeenager}");

bool A = grades > 90 && grades >= 100;
Console.WriteLine($"You are an adult: {A}");

Console.ReadLine();
*/


using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Give me a number.");

string a = Console.ReadLine();
float b = Convert.ToSingle(a);
Console.WriteLine(b);

int c = (int)b;
string finalNumber = c.ToString();
Console.WriteLine(c);