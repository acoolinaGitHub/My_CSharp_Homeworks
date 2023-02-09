// min sum in row

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
            arr[i, j] = rnd.Next(-10, 10);
            Console.Write(String.Format("{0,3}", arr[i, j]) + " ");
        }
        Console.WriteLine();
    }
    return arr;
}

int[,] a2d = Print2DArray(m, n);
Console.WriteLine("---------------------");
//===========================================================================

int[] SumRow(int[,] arr)                   // func: sum rows to 1D array
{
    int[] res = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)       
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        res[i] = sum;
    }
    return res;
    
}

void MinElement(int[] a)                     // func: find min element in 1D array
{
    int min = a[0];
    int i_min = 0;
    for (int i = 0; i < a.GetLength(0); i++)      
    {          
        if (a[i] < min)
        {
            min = a[i];
            i_min = i;
        }        
    }
    Console.Write($"==> Min Sum = {min} in the row: {i_min + 1}");
    Console.WriteLine();
}

int[] minSum = SumRow(a2d);
MinElement(minSum);
Console.WriteLine("---------------------");