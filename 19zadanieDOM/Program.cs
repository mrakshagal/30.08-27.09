// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.Write("Type five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2;
int num3;
if (num > 9999 && num <= 99999)
{
    if (num%10 == num/10000)
    {
    num2= num/1000;
    num3= num%100;
    if (num2%10 == num3/10)
    {
    Console.WriteLine($"{num} is palindrome!");
    }
    else Console.WriteLine("The number is not palindrome!");
    }
    else Console.WriteLine("The number is not palindrome!");
}
else Console.WriteLine("Five-digit number you dumbass");