// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Type integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
num1= num1 % 2;
if (num1==0)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}

