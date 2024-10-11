using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Input in km:");

string a = Console.ReadLine();
int b = Convert.ToInt32(a);
int c = ((b * 1000) / (60 * 60));

Console.WriteLine("You are driving " + c + " meters per second");