// recursion: Akkerman function (for M>=0 and N>=0)

Console.Clear();
Random rnd = new Random();

int m = rnd.Next(0, 5);
int n = rnd.Next(0, 5);

Console.WriteLine($"M = {m}, N = {n}");

int AkkermanRec(int x, int y)
{
    if (x == 0)
    {   
        return y + 1;
    }
    if (y == 0)
    {        
        return AkkermanRec(x - 1, 1);
    }
    else
    {        
        return AkkermanRec(x - 1, AkkermanRec(x, y - 1));
    }
}

System.Console.WriteLine($"--> A(m, n) = {AkkermanRec(m, n)}");  

