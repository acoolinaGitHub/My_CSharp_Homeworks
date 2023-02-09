// find element [i,j] in array

Console.Clear();
Random rnd = new Random();

int m = rnd.Next(2, 10);
int n = rnd.Next(2, 10);

Console.Write($"m = {m}, n = {n}");
Console.WriteLine();

int[,] InitArray(int x, int y)               // func: get random array
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < x; i++)     
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = rnd.Next(-10, 10);
        }
    }
    return arr;
}

void Print2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)      // func: print 2D array
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] a2d = InitArray(m,n);
Print2DArray(a2d);

Console.WriteLine("----------------------------");

int i = rnd.Next(0, 15);
int j = rnd.Next(0, 15);

Console.Write($"i = {i}, j = {j}");
Console.WriteLine();

if ((i >= m) || (j >= n))
{
    Console.WriteLine($"==> Exception: a[{i}, {j}] is Out of array");
}
else Console.WriteLine($"==> Element a[{i}, {j}]:  {a2d[i,j]}");

Console.WriteLine("----------------------------");



