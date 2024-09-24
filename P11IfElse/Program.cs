Console.WriteLine("What is your age?");

int age = int.Parse(Console.ReadLine());

string outputMessage = age <= 13 ? "You are a child." : age <= 13 || age <= 17 ? "You are a teenager." : "You are an adult.";
Console.WriteLine(outputMessage);


Console.WriteLine("Give me another number");

int number = int.Parse(Console.ReadLine());

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