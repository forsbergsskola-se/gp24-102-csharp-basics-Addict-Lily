Console.WriteLine("Write side a and side b of the right triangle:");

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

double hypotenuse = Math.Sqrt((a * a) + (b * b));

Console.WriteLine($"The length of the hypotenuse of a right triangle is {hypotenuse}.");



