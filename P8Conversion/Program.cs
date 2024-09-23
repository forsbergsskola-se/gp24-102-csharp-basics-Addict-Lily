using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Give me a number.");

string a = Console.ReadLine();
float b = Convert.ToSingle(a);
Console.WriteLine(b);

int c = (int)b;
Console.WriteLine(c);
