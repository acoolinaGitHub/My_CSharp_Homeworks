// random double array (m x n)

Console.Clear();
Random rnd = new Random();

int m = rnd.Next(2,10);
int n = rnd.Next(2,10);

double[,] arr = new double[m,n];

double GenRndDouble (int a, int b)  // func: double number generation 
{
    double rndDouble = a + rnd.NextDouble() * (b - a);
    return rndDouble;
}

Console.Write($"m = {m}, n = {n}");
Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)      // fill array of random numbers
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = GenRndDouble(-10,10);
    }
}

for (int i = 0; i < arr.GetLength(0); i++)      // print array
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(Math.Round(arr[i,j],2) + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

