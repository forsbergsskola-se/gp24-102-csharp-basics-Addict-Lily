
Console.WriteLine("How old are you?");

string userInput = Console.ReadLine();
int age = int.Parse(userInput);

bool isChild = age <= 12;
Console.WriteLine($"You are a child: {isChild}");

bool isTeenager = age >= 13 && age < 19;
Console.WriteLine($"You are a teenager: {isTeenager}");

bool isAdult = age >= 19;
Console.WriteLine($"You are an adult: {isAdult}");
