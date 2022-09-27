//Два числа. является ли одно число квадратом другого 
Console.Clear();
Console.Write("Type integer number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Type one more integer number:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1/num2==num2)
{
    Console.WriteLine($"{num1} is the square of {num2}");
}
else if (num2/num1==num1)
{
    Console.WriteLine($"{num2} is the square of {num1}");
}
else 
{
    Console.WriteLine("Try again");
}
