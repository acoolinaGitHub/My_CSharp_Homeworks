//Table of cubes

Console.Clear();
Console.Write("Please enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0) Console.Write($"{n} < 0. Please enter a natural number.");
else
{
    Console.Write($"{n} --> ");

    for (int i = 1; i <= n; i++)
    {   
        int res;
        res = Convert.ToInt32(Math.Pow(i,3));

        if (i == n) Console.Write($"{res} ");
        else Console.Write($"{res}, ");
    }
}
Console.WriteLine();
