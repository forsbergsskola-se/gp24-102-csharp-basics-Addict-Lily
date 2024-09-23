using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Write your time in minutes:");

string a = Console.ReadLine();
int b = Convert.ToInt32(a);
int c = (b * 60);

Console.WriteLine("Your minute has " + c + " seconds.");