//E.g. by Fredrik

string patternOne = "-#-#-#-#-#";
string patternTwo = "#-#-#-#-#-";

Console.WriteLine("Enter a size!");

int outputSize = int.Parse(Console.ReadLine());

backtrack:

if (outputSize % 2 == 0)
    Console.WriteLine(patternOne);
else
    Console.WriteLine(patternTwo);

outputSize--;
if (outputSize > 0)
    goto backtrack;


 