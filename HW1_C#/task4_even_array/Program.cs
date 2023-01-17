// Find even numbers in array

Console.Clear();
Console.Write("Please enter size of array: N = ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;

if ((n < 1) || (n == 1))
{
    Console.Write("Please imput N>1");
}
else 
{
    Console.Write($"Result: N={n} --> ");
};

while (i <= n)
{
    Console.Write(i + " ");
    i = i + 2;
}
