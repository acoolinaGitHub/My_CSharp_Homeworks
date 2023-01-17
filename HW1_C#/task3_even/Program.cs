// Check even numbers

Console.Clear();
Console.Write("Please enter int number: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x%2 == 0) Console.WriteLine($"Result: YES, {x} is even number");
else Console.WriteLine($"Result: NO, {x} is not even number");
