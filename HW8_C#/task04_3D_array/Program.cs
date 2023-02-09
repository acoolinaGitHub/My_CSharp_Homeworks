// 3D array with indexes

Console.Clear();
Random rnd = new Random();

bool ContainsTheSameNumber(int[] a, int current, int n)  // check if a number repeats
{
    for (int i = 0; i < current; i++)
    {
        if (a[i] == n)
        {
            return true;
        }
    }
    return false;
}

int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);
int k = rnd.Next(2, 5);

int[,,] Print3DArray(int x, int y, int z)               // func: get and print random 3D array
{
    int[,,] arr = new int[x, y, z];
    int[] a1d = new int[x * y * z];

    int ai = 0;

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int p = 0; p < z; p++)
            {
                int n = rnd.Next(0, 100);                
                while (ContainsTheSameNumber(a1d, ai, n))  // check and replace duplicate number
                {
                    n = rnd.Next(0, 100);
                }
                a1d[ai++] = n;
                arr[i, j, p] = n;

                Console.Write(String.Format("{0,3}", arr[i, j, p]) + $"({i},{j},{p})" + " ");  
            }
        }
        Console.WriteLine();
    }
    return arr;
}

Console.Write($"3DArray ({m}x{n}x{k}):");
Console.WriteLine();
Console.WriteLine("---------------------");
int[,,] a3D = Print3DArray(m, n, k);
Console.WriteLine("---------------------");

//===========================================================================

