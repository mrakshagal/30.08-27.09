// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.WriteLine("Type the number from 100 to 999: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    number = number % 10;
    Console.WriteLine($"The last number is:{number}");
}
else 
{
    Console.WriteLine("Wrong number, try again");
}