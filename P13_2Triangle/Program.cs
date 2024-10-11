//E.g. by Fredrik

Console.WriteLine("Please input the desired size of your triangle:");

retry:
bool parsed = int.TryParse(Console.ReadLine(), out int desiredSize);

if (!parsed)
{
    Console.WriteLine("Please try only numerical values:");
    goto retry;
}

continuation:
Console.WriteLine(new string('#', desiredSize--));

if(desiredSize > 0)
    goto continuation;