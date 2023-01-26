// Exponential number (A^|B|)

Console.Clear();
Random rnd = new Random();
int a = rnd.Next(-10,10);
int b = rnd.Next(-10,10);
Console.WriteLine($"Number   --> {a}^{b}");

int DegreeFunc()
{
    return Convert.ToInt32(Math.Pow(a, Math.Abs(b)));
}

Console.WriteLine($"Result: A^|B| = {DegreeFunc()}");




