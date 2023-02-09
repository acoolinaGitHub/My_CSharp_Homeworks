// DESC sort in rows in array (m x n)
Console.Clear();
Random rnd = new Random();

int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);

Console.Write($"m = {m}, n = {n}");
Console.WriteLine();
Console.WriteLine("---------------------");

int[,] PrintArray(int x, int y)               // func: get and print random array
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = rnd.Next(-10, 10);
            Console.Write(String.Format("{0,3}", arr[i, j]) + " ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] a2d = PrintArray(m, n);
Console.WriteLine("---------------------");
//-----------------------------------------------------------------------------------

void DESCSortedArray(int[,] arr)               // func: DESC sorted array
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = arr.GetLength(1) - 1; k > j; k--)
            {
                if (arr[i, k] > arr[i, k - 1])
                {
                    int buf = arr[i, k];
                    arr[i, k] = arr[i, k - 1];
                    arr[i, k - 1] = buf;
                }
            }

            Console.Write(String.Format("{0,3}", arr[i, j]) + " ");
        }
        Console.WriteLine();
    }
}

DESCSortedArray(a2d);
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
