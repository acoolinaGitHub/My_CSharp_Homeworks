// count of even numbers in array

Console.Clear();
Random rnd = new Random();
int[] arr = new int[rnd.Next(10)];

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100,1000);
    if (i == arr.Length-1)          // print array
    {
        Console.Write(arr[i]); 
    }
    else Console.Write(arr[i] +", "); 
}

int count = 0;
foreach (var item in arr)
{
    if (item % 2 == 0)
    {
        count++;
    }    
}
Console.WriteLine($"] ==> Count: {count}");

// void RecursRevers(int[] arr, int i, int j)     // example: Reverse of array
// {
//     if (i>=j)
//     {
//         return;
//     }
//     else 
//     {
//         int tmp = arr[i];
//         arr[i] = arr[j];
//         arr[j] = tmp;

//         RecursRevers(arr, i + 1, j - 1);
//     }
// }

// RecursRevers(arr, 0, arr.Length - 1);