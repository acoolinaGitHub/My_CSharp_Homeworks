// sum of numbers on odd positions in array

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

int sum = 0;
for (int i = 0; i < arr.Length; i++)
{        
    if (i % 2 == 1)
    {
        sum = arr[i] + sum;
    }    
}
Console.WriteLine($"] ==> Sum: {sum}");
