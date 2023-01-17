// Find min, max

Console.Clear();
Console.Write("Please enter two int number: the first one = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(" and the second one = ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.Write($"Result: Max = {x} and Min = {y}");
}
else if (x < y)
{
    Console.Write($"Result: Min = {x} and Max = {y}");
}
else
{
    Console.Write($"Both numbers are equal = {x}");
}