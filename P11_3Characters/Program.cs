Console.WriteLine("Write a single character: ");

char userInput = Console.ReadKey().KeyChar;
Console.ReadLine();

if ("aeiouAEIOU".IndexOf(userInput) >=0)
{
    Console.WriteLine("That's a vowel.");
}
else if (char.IsLetter(userInput))
{
    Console.WriteLine("That's a consonant.");
}
else if (char.IsDigit(userInput))
{
    Console.WriteLine("That's a digit.");
}
else
{
    Console.WriteLine("That's not valid input");
}