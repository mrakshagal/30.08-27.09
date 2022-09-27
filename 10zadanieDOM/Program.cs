// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Type three-digit number:");
int num1 = Convert.ToInt32(Console.ReadLine());
int twodigits = num1 % 100;
int seconddigit = twodigits /10;
if (num1 > 99 && num1 < 1000)
{
    Console.WriteLine($"{seconddigit}");
}
else 
{
    Console.WriteLine($"Try again");
}
