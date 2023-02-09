// word frequency in 2D array
Console.Clear();
Random rnd = new Random();

int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);

Console.Write($"m = {m}, n = {n}");
Console.WriteLine();
Console.WriteLine("---------------------");

int[,] Print2DArray(int x, int y)               // func: get and print random array
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            arr[i, j] = rnd.Next(-9, 10);
            Console.Write(String.Format("{0,3}", arr[i, j]) + " ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] a2d = Print2DArray(m, n);
Console.WriteLine("---------------------------");
//===========================================================================================

void ElementFrequency(int[,] a)                     // func: find NUMBER frequency in 2D array
{
    for (int k = 0; k <= 9; k++)
    {
        int count = 0;
        for (int i = 0; i < a.GetLength(0); i++)      
        {          
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (Math.Abs(a[i,j]) == k)
                {
                    count++;
                }  
            }      
        }
        Console.Write($"==> Number = {k} -> {count} time(s)");
        Console.WriteLine();
    }
}

ElementFrequency(a2d);
Console.WriteLine("---------------------------");