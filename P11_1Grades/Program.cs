Console.WriteLine("Write your grade:");

string input = Console.ReadLine();
int grade = int.Parse(input);

if (grade < 60)
{
    Console.WriteLine("Your grade is F");
}
else if (grade == 60 || grade <= 69)
{
    Console.WriteLine("Your grade is D");
}
else if (grade == 70 || grade <= 79)
{
    Console.WriteLine("Your grade is C");
}
else if (grade == 80 || grade <= 89)
{
    Console.WriteLine("Your grade is B");
}
else if (grade == 90 || grade <= 100)
{
    Console.WriteLine("Your grade is A");
}
else
{
    Console.WriteLine("Try again.");
}