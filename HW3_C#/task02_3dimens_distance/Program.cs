//Find the distance in 3D
Console.Clear();
Random rnd = new Random();
int x1 = rnd.Next(-100,100);
int x2 = rnd.Next(-100,100);
int y1 = rnd.Next(-100,100);
int y2 = rnd.Next(-100,100);
int z1 = rnd.Next(-100,100);
int z2 = rnd.Next(-100,100);
Console.WriteLine($"Random coordinates (1) --> ({x1}, {y1}, {z1})");
Console.WriteLine($"Random coordinates (2) --> ({x2}, {y2}, {z2})");

int res = 0;
res = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(x1-x2),2) + Math.Pow(Math.Abs(y1-y2),2) + Math.Pow(Math.Abs(z1-z2),2)));
Console.WriteLine($"=> Distance: {res}");
Console.WriteLine();