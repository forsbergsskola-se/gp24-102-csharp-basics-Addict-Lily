Console.WriteLine("What is your age?");

string userAge = Console.ReadLine();
int age = int.Parse(userAge);

string outputMessage = age <= 13 ? "You are a child." : age <= 13 || age <= 17 ? "You are a teenager." : "You are an adult.";
Console.WriteLine(outputMessage);


Console.WriteLine("Give me another number");

string userNumber = Console.ReadLine();
int number = int.Parse(userNumber);

if (number < age)
{
    Console.WriteLine("Your number is lower then your age");
}
else if (number > age)
{
    Console.WriteLine("Your number is higher then your age");
}

if (number == age)
{
    Console.WriteLine("Your age is the same as your number.");
}

if (number % 2 == 0)
{
    Console.WriteLine("Your number is even");
}
else
{
    Console.WriteLine("Your number is odd");
}