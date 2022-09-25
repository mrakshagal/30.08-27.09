// Программа, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа

int number = new Random().Next(10, 100);
int firstdigit = number / 10;
int seconddigit = number % 10;
if (firstdigit > seconddigit)
{
    Console.WriteLine($"The biggest digit of {number} is {firstdigit}");
}
else
{
    Console.WriteLine($"The biggest digit of {number} is {seconddigit}");
}
