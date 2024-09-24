Console.WriteLine("What is your age?");

string userAge = Console.ReadLine();
int age = int.Parse(userAge);

if (age <= 13)
{
    Console.WriteLine("You are a child.");
}
else if (age <= 13 && age >= 18)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are an adult.");
}


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