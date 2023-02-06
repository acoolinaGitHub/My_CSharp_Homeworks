// find count of positive numbers from range of numbers 
// (example: " 45 -37x-3a+3- 77   55x v22  b ")

Console.Clear();
Console.Write("Please enter int numbers separated by spaces --> ");
string? str = Console.ReadLine();

bool isMinus(char c)
{
    return c == '-';
    //return str.Contains("-");
}

bool isDigit(char c)
{
    return Char.IsDigit(c);
}

int count = 0;
bool number = false;
bool negative = false;

foreach (var item in str)
{
    if (isDigit(item))
    {
        number = true;
    }
    else if (isMinus(item) && !number)
    {
        negative = true;
    }
    else if (number && !negative && !isDigit(item))
    {
        count++;
        number = false;
        negative = false;
        if (isMinus(item))
        {
            negative = true;
        }
    }
    else
    {
        number = false;
        negative = false;
    }
}

if (number && !negative)
{
    count++;
}

Console.WriteLine();
Console.WriteLine($"==> Positive numbers (count) = {count}");
Console.WriteLine();