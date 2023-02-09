// scalar product of 2 arrays
Console.Clear();
Random rnd = new Random();

int m = rnd.Next(2, 4);
int n = rnd.Next(2, 4);
int k = rnd.Next(2, 4);
int l = rnd.Next(2, 4);

int[,] Print2DArray(int x, int y)               // func: get and print random array
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

Console.Write($"Array1 ({m}x{n}):");
Console.WriteLine();
Console.WriteLine("---------------------");
int[,] a1 = Print2DArray(m, n);
Console.WriteLine("---------------------");

Console.Write($"Array2 ({k}x{l}):");
Console.WriteLine();
Console.WriteLine("---------------------");
int[,] a2 = Print2DArray(k, l);
Console.WriteLine("---------------------");
//=========================================================================================

int[,] MatrixMultiply(int[,] arr1, int[,] arr2)               // func: get and print scalar array
{
    int m = arr1.GetLength(0);
    int l = arr1.GetLength(1);
    int[,] scalar = new int[m, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < l; j++)
        {
            int sum = 0;
            for (int b = 0; b < n; b++)
            {
                sum = sum + arr1[i, b] * arr2[b, j];
                scalar[i, j] = sum;                
            }            
            Console.Write(String.Format("{0,4}", scalar[i, j]) + " ");
        }
        Console.WriteLine();
    }
    return scalar;
}

if (n != k)
{
    Console.WriteLine("==> Error. The matrices are not identical. Please, try again!");
    Console.WriteLine("---------------------");
}
else
{
    Console.Write($"Scalar ({m}x{l}):");
    Console.WriteLine();
    Console.WriteLine("---------------------");
    int[,] a3 = MatrixMultiply(a1, a2);
    Console.WriteLine("---------------------");
}
