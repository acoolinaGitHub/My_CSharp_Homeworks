﻿//Find the third number of xy..z

Console.Clear();
Random rnd = new Random();
int x = rnd.Next(1,10000000);
Console.WriteLine($"Random = {x}");

if (x > 99)
{
    while (x > 999)
    { 
        x = x / 10;   // get number without last digit    
    }
    x = x % 10;       // get last digit
    Console.WriteLine($"The third number = {x}");
}
else Console.WriteLine($"Exeption: the third number is abcent");


// int b1=-1; 
// int b2=-1;
// int b3=-1;

// while (x !=0)
// {
//     b3 = b2;
//     b2 = b1;
//     b1 = x % 10;  // get last digit  
//     x = x / 10;   // get number without last digit
// }

// if (b3 == -1) 
// {
//     Console.WriteLine($"Exeption: the third number is abcent");
// }
// else Console.WriteLine($"The third number = {b3}");

