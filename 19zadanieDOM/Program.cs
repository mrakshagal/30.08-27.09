
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Module(int num)
{
    if (num < 0)
    {
        return -num;
    }
    else return num;
}
int result = Module(number);
void Reverse(int num1)
{
    if (num1 / 10000 == num1 % 10 && num1 % 100 / 10 == num1 % 10000 / 1000)
    {
        Console.WriteLine($"Палиндром");
    }
    else Console.WriteLine($"НЕ палиндром");
}
if (result > 9999 & result <= 99999)
{
    Reverse(result);
}
else Console.WriteLine($"Введено некорректное число");