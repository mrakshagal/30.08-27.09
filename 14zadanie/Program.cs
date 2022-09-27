// Принимает число и проверяет, кратно ли оно одновременно 7 и 23

Console.Clear();
Console.Write("Type integer number:");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1%7 ==0)
{
    if(num1%23==0)
    {
        Console.WriteLine ($"{num1} is multiple of 7 and 23");
    }
    else
    {
        Console.WriteLine($"{num1} is not multiple of 7 and 23");
    }
}
else
{
    Console.WriteLine($"{num1} is not multiple of 7 and 23");
}