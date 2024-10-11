Console.WriteLine("Give me a number: ");

int userInput = int.Parse(Console.ReadLine());

if (userInput % 2 == 0)
{
    Console.WriteLine("Your number is even");
}
else
{
    Console.WriteLine("Your number is odd");
}