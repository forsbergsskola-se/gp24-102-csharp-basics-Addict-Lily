//E.g. by Fredrik

Console.WriteLine("Welcome to the bank of Cyberica!");
Console.WriteLine("Please input how much you want to withdraw:");

int withDrawAmount;

while (!int.TryParse(Console.ReadLine(), out withDrawAmount))
{
    Console.WriteLine("Please, try again");
}
Console.WriteLine("Thank you");
Console.WriteLine($"Here is your desired amount: {new string('$', withDrawAmount)}");