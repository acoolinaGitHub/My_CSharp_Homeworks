// delete row and column with MIN element in 2D array

Random rnd = new Random();
Console.Clear();
int m = rnd.Next(2, 7);
int n = rnd.Next(2, 7);

Console.Write($"m = {m}, n = {n}");
Console.WriteLine();
Console.WriteLine("---------------------------");

int[,] Print2DArray(int x, int y)               // func: get and print random array
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-10, 10);
            Console.Write(String.Format("{0,3}", arr[i, j]) + " ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] a2d = Print2DArray(m, n);
Console.WriteLine("---------------------------");
//===========================================================================================

void MinElement(int[,] arr)                     // func: find MIN element in 2D array and print cutted 2D array
{
    int min = arr[0, 0];
    int i_min = 0;
    int j_min = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                i_min = i;
                j_min = j;
            }
        }
    }
    Console.Write($"==> MIN = {min} in the {i_min + 1} ROW and in the {j_min + 1} COLUMN");
    Console.WriteLine();
    Console.WriteLine("---------------------------");

    for (int i = 0; i < arr.GetLength(0); i++)                  // print cutted 2D array
    {
        if (i != i_min)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != j_min)
                {
                    Console.Write(String.Format("{0,3}", arr[i, j]) + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

MinElement(a2d);
Console.WriteLine("---------------------------");