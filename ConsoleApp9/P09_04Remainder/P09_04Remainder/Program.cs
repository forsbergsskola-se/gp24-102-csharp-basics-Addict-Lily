Console.WriteLine("Write two numbers:");

string input1 = Console.ReadLine();
float a = Convert.ToSingle(input1);

string  input2 = Console.ReadLine();
float b = Convert.ToSingle(input2);

float sum = a % b;
Console.WriteLine(sum);

