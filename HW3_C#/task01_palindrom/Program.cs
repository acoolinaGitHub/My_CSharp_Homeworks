//Check the palindrom

Console.Clear();
// Random rnd = new Random();
// int x = rnd.Next(0,100000000);
// Console.WriteLine($"Number = {x}");
Console.Write("Please enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());

//----------------------------------------------- //changed to => int i = Convert.ToInt32(Math.Ceiling(Math.Log10(x)));

// int FindDigits (int count) // find the quantity of digits in {x}     
// {
//     count = 0;    
//     if (x == 0)
//     {
//         Console.WriteLine("Count = 1");
//     }
//     else
//     {
//         while (x > 0)
//         {    
//             count++;
//             x = x / 10;
//         }
//     Console.WriteLine($"Count = {count}");
//     }
//     return count;
// }
//-----------------------------------------------

bool CheckIsPalindrom(int x)
{
    //int i = FindDigits(x);
    int i = Convert.ToInt32(Math.Ceiling(Math.Log10(x)));
    Console.WriteLine($"i = {i}");
    while (i > 1) 
    {
        int a = Convert.ToInt32(Math.Pow(10,i-1)); // exponentiation {i-1}
        int right_number = x % 10;
        int left_number = x / a;
        Console.WriteLine($"(L:{left_number}, R:{right_number})");
        if (right_number != left_number) return false;
        x = (x % a) / 10;
        if (x == 0) Console.WriteLine($"Nothing is Remaining");
        else Console.WriteLine($"--> Remaining digit: {x}");
        i = i - 2;        
    }
    return true;
}

Console.WriteLine();
if (CheckIsPalindrom(x)) Console.WriteLine("=> Result: The number IS palindrom!");
else Console.WriteLine("=> Result: The number IS NOT palindrom!");
Console.WriteLine();