// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Clear();
Console.Write("Type three integer numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"The biggest number is {num1}");
    }
    else if (num1 < num3)
    {
        Console.WriteLine($"The biggest number is {num3}");
    }
}
else if (num2 > num1)
{
    if (num2 > num3)
    {
        Console.WriteLine($"The biggest number is {num2}");
    }
    else if (num2 < num3)
    {
        Console.WriteLine($"The biggest number is {num3}");
    }
}
else 
{
    Console.WriteLine("Wrong numbers.Try again");
}