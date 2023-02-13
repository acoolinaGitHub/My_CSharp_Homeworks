// recursion: sum of natural number range (from M to N)

Console.Clear();
Random rnd = new Random();

int m = rnd.Next(-10, 10);
int n = rnd.Next(-10, 10);
Console.WriteLine($"M = {m}, N = {n}");
Console.Write("--> ");

int SumNumberRec(int i, int n, int sum = 0)
{
    if (i > n)
    {   
        return sum;
    }
    if (i < 1)
    {
        i = 0;
        return i + SumNumberRec(++i, n, sum);
    }
    else
    {        
        return i + SumNumberRec(++i, n, sum);
    }
}

if (m > n)
{
    Console.WriteLine("Error: M > N. Retry again please");
}
else
{
    SumNumberRec(m, n);    
}

if (n >= m)
{
    System.Console.WriteLine($" Sum of natural numbers = {SumNumberRec(m, n)}");
}




