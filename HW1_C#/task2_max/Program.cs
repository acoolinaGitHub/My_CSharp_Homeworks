// Find min, max

Console.Clear();
Console.Write("Please enter three int number: the first one = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(" and the second one = ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write(" and the third number = ");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;

if (y > max)
{
    max = y;
}
if (z > max)
{
    max = z;
}

Console.Write($"Result: Max = {max} ");
Console.Write("(");

if (x == max) Console.Write($"N1 ");
if (y == max) Console.Write($"N2 ");
if (z == max) Console.Write($"N3");

Console.Write(")");