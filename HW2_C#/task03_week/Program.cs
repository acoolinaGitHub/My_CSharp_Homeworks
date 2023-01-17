// Check weekend day

Console.Clear();
Console.Write("Please enter day number: ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
    Console.Write("1 - It is Monday, go to work!");
    break;  

    case 2:
    Console.Write("2 - It is Tuesday, go to work!");
    break; 

    case 3:
    Console.Write("3 - It is Wednesday, go to work!");
    break; 

    case 4:
    Console.Write("4 - It is Thursday, go to work!");
    break; 

    case 5:
    Console.Write("5 - It is Friday, still gotta go to work");
    break; 

    case 6:
    Console.Write("6 - Yeap, it is Saturday, day off!");
    break; 

    case 7:
    Console.Write("7 - Yeap, it is Sunday, day off!");
    break; 

default:
    Console.Write("Incorrect: there is no such week day. Please use 1-7 numbers.");
    break; 
};