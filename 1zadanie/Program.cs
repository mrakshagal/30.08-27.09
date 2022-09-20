// Напишите программу, которая 1. на вход принимает два
// числа и 2. проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();
Console.Write("Type two integer numbers:");
int num1 = Convert.ToInt32(Console.ReadLine()); 
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (square==num1)
{
Console.WriteLine($"a={num1}, b={num2}-yes");
}    
else 
{
    Console.WriteLine($"a={num1}, b={num2}-no");
}