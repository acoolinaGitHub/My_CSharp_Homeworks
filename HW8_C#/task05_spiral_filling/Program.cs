// spiral filling in 2D array

Console.Clear();
Random rnd = new Random();

int n = rnd.Next(2, 30);

int[,] Spiral(int n)                    // func: spiral filling
{
    int[,] res = new int[n, n];

    int pos = 0;
    int count = n;
    int value = -n;
    int sum = -1;

    do {
        value = -1 * value / n;
        for (int i = 0; i < count; i++) {
            sum += value;
            res[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++) {
            sum += value;
            res[sum / n, sum % n] = pos++;
        }
    } while (count > 0);

    return res;
}


void PrintArray(int[,] array)                           // func: print 2D array
{
    int n = (array.GetLength(0) * array.GetLength(1) - 1).ToString().Length + 1;

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(String.Format("{0,3}", array[i, j]) + " ");
        }
        Console.WriteLine();
    }
}

Console.Write($"Spiral2DArray ({n}x{n}):");
Console.WriteLine();
Console.WriteLine("---------------------");
int[,] a2d = Spiral(n);
PrintArray(a2d);
Console.WriteLine("---------------------");
