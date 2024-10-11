Console.WriteLine("Press enter for your new item");

Console.ReadLine();

string[] items = {"Bow and Arrow", "Magic Wand", "Axe", "Sword", "Magic Potion"};

Random random = new Random();

int randomNumber = random.Next(items.Length);
string randomItem = items[randomNumber];

Console.WriteLine($"Your item is: {randomItem}");


