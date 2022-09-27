// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Type number of the day of the week:");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (num1>0 && num1<6)
{
  Console.WriteLine("No");
}
else if (num1==6)
{
    Console.WriteLine("Yes");
}
else if (num1==7)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("There is no such day of the week");
}