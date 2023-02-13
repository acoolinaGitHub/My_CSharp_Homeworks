// recursion of natural number range (from N to 1)

Console.Clear();
Random rnd = new Random();

int n = rnd.Next(1, 30);
Console.WriteLine($"n = {n}");
Console.Write("--> ");

NumberRec(n);

void NumberRec(int n, int a = 1)
{
    if (a > n)
    {
        return;
    }
    else
    {
        Console.Write($" {n} ");
        NumberRec(--n, a);
    }
}