// diff of max and min in double array

Console.Clear();
Random rnd = new Random();
double[] arr = new double[10];

double genRndDouble (int a, int b)  // generate of double array
{
    double rndDouble = a + rnd.NextDouble() * (b - a);
    return rndDouble;
}

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = genRndDouble(-10,10);
    if (i == arr.Length-1)          // print array
    {
        Console.Write(Math.Round(arr[i],2)); 
    }
    else Console.Write(Math.Round(arr[i],2) +", "); 
}
Console.Write("]");
Console.WriteLine();

double min = arr[0];
double max = arr[0];
double diff = 0;
for (int i = 0; i < arr.Length; i++)
{        
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine($"--> Max: {Math.Round(max,2)}");

for (int i = 0; i < arr.Length; i++)
{        
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"--> Min: {Math.Round(min,2)}");   

diff = max - min;
Console.WriteLine($"==> Diff: {Math.Round(diff,2)}");  // or $"==> Diff: {diff:f2)}"
