// Sum of digits in number

Console.Clear();
Random rnd = new Random();
int x = rnd.Next(-100,1000);
Console.WriteLine($"Number = {x}");

int SumFunc()
{
    int i = 0;
    int digits =  Convert.ToInt32(Math.Ceiling(Math.Log10(Math.Abs(x)))); // get digits
    int res = 0;

    while (i < digits)
    {   
        int a = Math.Abs(x) % 10;
        res = res + a;
        x = Math.Abs(x) / 10;
        i++;
    }
    return res;
}

Console.WriteLine($"Result: {x} --> {SumFunc()}");