Console.WriteLine("Write the radius of the circle:");

string userInput = Console.ReadLine();

float r = Convert.ToSingle(userInput);
float circleArea = r * r;

float pi = 3.1415926535897932384626433832795f;

float A = pi * circleArea;

Console.WriteLine($"The area of the circle is {A}");