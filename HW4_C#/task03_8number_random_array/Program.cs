//Fill 8-digits number into array randomly

Console.Clear();
Random rnd = new Random();
int x = rnd.Next(Convert.ToInt32(Math.Pow(10,8)));
Console.WriteLine($"Number = {x}");

int digits =  Convert.ToInt32(Math.Ceiling(Math.Log10(Math.Abs(x))));  //get digits in number
Console.WriteLine($"digits = {digits}");

int[] InputArray()
{
    int[] a = new int [digits];
    for (int i = 0; i < digits; i++)  //fill -1 in array
    {
        a[i] = -1;
    }
    for (int i = 0; i < digits; i++)    //put digit into random place
    {
        int r_i = rnd.Next(0,digits);
        while (a[r_i] != -1)            //check if -1 then put digit
        {
            r_i = rnd.Next(0,digits);            
        }
        a[r_i] = x % 10;
        x = x / 10;
    }
return a;
}

Console.WriteLine("Array: ");
Console.Write("[");

int[] a = InputArray();
for (int i = 0; i < digits; i++)  Console.Write($" {a[i]}");  //print array

Console.Write("]");
Console.WriteLine();