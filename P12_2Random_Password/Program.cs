

Console.WriteLine("Random password with max 6 characters:");

string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz$%#@!*^&\";";

Random random = new Random();

string password = String.Empty;

for (int i = 0; i < 6; i++)
{
    password += chars[random.Next(chars.Length)];
}

Console.WriteLine($"Your new password is: {password}.");


string gotoPassword = string.Empty;

backtrack:

gotoPassword += chars[random.Next(chars.Length)];

if (gotoPassword.Length < 6)
{
    goto backtrack;
}
Console.WriteLine($"Your other new password is: {gotoPassword}.");