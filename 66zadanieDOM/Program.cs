int SumNaturalCount(int a, int b)
{
    if (a < b)
    {
        if (a == b)
            return b;
        return b + SumNaturalCount(a, b - 1);
    }
    else
    {
        if (b == a)
            return a;
        return a + SumNaturalCount(b, a - 1);
    }
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N");
Console.WriteLine("--------------------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("--------------------------------------------------");
if (m == n)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Введены идентичные числа, сумма единственного элемента: {m}");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Сумма элементов от {m} до {n} : {SumNaturalCount(m, n)}");
}