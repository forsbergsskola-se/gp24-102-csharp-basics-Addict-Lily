Console.WriteLine("Give me the x, y coordinates of my enemy.");

Random random = new Random();
int xCoordinate = random.Next(1, 100);
int yCoordinate = random.Next(1, 100);

Console.WriteLine($"Your enemy is at position {xCoordinate}, {yCoordinate}");
