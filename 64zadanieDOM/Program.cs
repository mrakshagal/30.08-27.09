int NaturalNumber(int a, int b)
{
    if (a == b)
        return a;
    else
        Console.Write($"{NaturalNumber(a, b + 1)}, ");
    return b;
}


Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Вывод всех натуральных чисел в промежутке от N до 1");
Console.WriteLine("###################################################");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
if (n < 1)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Введено некорректное число");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("*****************************");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(NaturalNumber(n, m));
}