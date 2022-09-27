//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Type integer number:");
int num1= Convert.ToInt32(Console.ReadLine());
int num2 = num1%10;
int num3 = num1/10;
int num4= num3%100;
int num5= num4%10;


if (num1/100==0)
{
    Console.WriteLine("There is no third digit");
}
else if (num1 > 99 && num1< 999)
{
    Console.WriteLine($"The third digit of number {num1} is {num2}");
}
else
{
    while (num3>1000)
    {
        num3= num1/10;
        num4= num3%100;
    num5= num4%10;
    }
    Console.WriteLine($"The third digit of number {num1} is {num5}");
}