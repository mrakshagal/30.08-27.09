Console.Clear();
Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int accum = 0;
int count = 0;
if (num < 0) num = -num;
int Countingdigits(int num1, int accum1, int i)
{
    while (num1 != 0)
    {
        accum1 = accum1 + num1 % 10;
        num1 = num1 / 10;
        i++;
    }
    return accum1;
}
int result = Countingdigits(num, accum, count);
Console.WriteLine("-------------------------");
Console.WriteLine($"Сумма цифр в введенном числе составит {result}");
