// diff of max and min in array

Console.Clear();
Random rnd = new Random();
int[] arr = new int[rnd.Next(10)];

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1,10);
    if (i == arr.Length-1)          // print array
    {
        Console.Write(arr[i]); 
    }
    else Console.Write(arr[i] +", "); 
}
Console.Write("]");
Console.WriteLine();

int min = arr[0];
int max = arr[0];
int diff = 0;
for (int i = 0; i < arr.Length; i++)
{        
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
Console.WriteLine($"--> Max: {max}");

for (int i = 0; i < arr.Length; i++)
{        
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"--> Min: {min}");

diff = max - min;
Console.WriteLine($"==> Diff: {diff}");
