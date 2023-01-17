//Find the second number of xyz

Console.Clear();
Random rnd = new Random();

int a = rnd.Next(100,1000);
Console.WriteLine($"Random = {a}");

int n = a/10%10;

Console.WriteLine($"The second number = {n}");