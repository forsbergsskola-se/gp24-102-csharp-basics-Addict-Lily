using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Write three numbers separate them with comma: ");

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 <= num2 && num2 <= num3)
{Console.WriteLine(num1);}

else if (num2 <= num3 && num3 <= num1)
{Console.WriteLine(num2);}

else
{Console.WriteLine(num3);}


if (num1 > num2 && num2 > num3)
{Console.WriteLine(num1);}

else if (num2 > num3 && num3 > num1)
{Console.WriteLine(num2);}

else
{Console.WriteLine(num3);}


