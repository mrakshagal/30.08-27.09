double AckermanFunction(double i, double j)
{
    if (i == 0)
        return j + 1;
    if (i > 0 && j == 0)
        return AckermanFunction(i - 1, 1);
    else
        return AckermanFunction(i - 1, AckermanFunction(i, j - 1));
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Вычисления функции Аккермана");
Console.WriteLine("----------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Введите число M: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число N: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("----------------------------");
if (m < 0 || n < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введено отрицательное число");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"A({m},{n}) = {AckermanFunction(m, n)}");
}