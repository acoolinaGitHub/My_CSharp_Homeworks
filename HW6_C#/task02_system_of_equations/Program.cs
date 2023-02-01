// solve the system of equations
// y = k1 * x + b1
// y = k2 * x + b2

Console.Clear();
Random rnd = new Random();
int k1 = rnd.Next(-10,100);
int b1 = rnd.Next(-10,100);
int k2 = rnd.Next(-10,100);
int b2 = rnd.Next(-10,100);
Console.WriteLine($"Numbers --> k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2},");

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("==> Result: There are an infinite number of solutions");
}
else if ((k1 == k2) && (b1 != b2))
{
    Console.WriteLine("==> Result: No solutions");
}
else
{
    int x = (b2-b1) / (k1-k2);
    int y = k1*x + b1;
    Console.WriteLine($"==> Result: ({x}, {y})");
}
Console.WriteLine();

