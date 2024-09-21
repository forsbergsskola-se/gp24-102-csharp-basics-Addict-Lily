Console.WriteLine("Write side a and side b of the right triangle:");

float a = float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());

float hypotenuse = a * a + b * b;

Console.WriteLine($"The length of the hypotenuse of a right triangle is {Math.Sqrt(hypotenuse)}.");



