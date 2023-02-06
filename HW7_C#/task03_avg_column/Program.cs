// avg for columns in random int array (m x n)

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

void PrintArray(double[] a)                     // func: print 1D array
{
    for (int i = 0; i < a.GetLength(0); i++)      
    {
            Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

double[] AvgArray(int[,] arr)                   // func: avg of columns
{
    double[] res = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)       
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j,i];
        }
        double avg = Math.Round(((double)sum / arr.GetLength(0)),2);
        res[i] = avg;
    }
    return res;
    
}

int[,] a2d = InitArray(m,n);
Print2DArray(a2d);

Console.WriteLine("---------------------");

double[] avg = AvgArray(a2d);
PrintArray(avg);

Console.WriteLine("---------------------");

