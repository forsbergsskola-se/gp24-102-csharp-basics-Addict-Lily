//This is my code.

Console.WriteLine("Give me a number of seconds");

string userInput = Console.ReadLine();
int inputSeconds = int.Parse(userInput);

int days = inputSeconds / 86400;
int remainingSeconds = inputSeconds % 86400;
Console.WriteLine(days);

int hours = remainingSeconds / 3600;
int remainingHours = inputSeconds % 3600;
Console.WriteLine(hours);

int minutes = remainingHours / 60;
int reiningMinutes = inputSeconds % 60;
Console.WriteLine(minutes);

int seconds = reiningMinutes % 60;
Console.WriteLine(seconds);

Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");

Console.WriteLine($"{days}.{hours}:{minutes}:{seconds}");
Console.WriteLine($"In total that is {(double)inputSeconds / 86400} days.");


//This is Fredrik's code.
/*Console.WriteLine("Give me a number of seconds");
 
 string userInput = Console.ReadLine();
int seconds = int.Parse(userInput);

int numberOfDays = seconds / (24 * 3600);
int remainingSeconds = seconds % (24 * 3600);
int numberOfHours = remainingSeconds / 3600;
remainingSeconds %= 3600;
int numberOfMinutes = remainingSeconds / 60;
int numberOfSeconds = remainingSeconds % 60;

Console.WriteLine("Number of days " + numberOfDays);
Console.WriteLine("Number of hours " + numberOfHours);
Console.WriteLine("Number of minutes " + numberOfMinutes);
Console.WriteLine("Number of seconds " + numberOfSeconds);

Console.WriteLine($"{numberOfDays}.{numberOfHours}:{numberOfMinutes}:{numberOfSeconds}");

Console.WriteLine($"In total that is {(float)seconds / 86400} days.");
// or
Console.WriteLine($"In total that is {(double)seconds / 86400} days.");
*/

