Console.Clear();
Console.Write("Type integer number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Type one more integer number:");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3= num1%num2;
if (num1>num2)
{
    if (num3==0)
    {
        Console.WriteLine($"{num1} is multiple of the number {num2}");
    }
    else 
    {
        Console.WriteLine($"{num1} is not multiple of the number {num2} and the rest is {num3}");
    }
}
else 
{
    Console.WriteLine("Try again");
}

