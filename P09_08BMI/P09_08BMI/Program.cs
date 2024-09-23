using System.Globalization;
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Please enter your weight in kilograms and your height in meters.");

float kg = float.Parse(Console.ReadLine());
float height = float.Parse(Console.ReadLine());

float doubleHeight = height * height;
float BMI = kg / doubleHeight;

Console.WriteLine(BMI);