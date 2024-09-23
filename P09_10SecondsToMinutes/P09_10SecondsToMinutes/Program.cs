Console.WriteLine("Write time in seconds, and I will convert it to minutes and remaining seconds:):");

int seconds = int.Parse(Console.ReadLine());

int minutes = seconds / 60;
int remainingSeconds = seconds % 60;


Console.WriteLine($"Your result is {minutes} minutes and {remainingSeconds} seconds.");
