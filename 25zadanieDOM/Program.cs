Console.Clear();
Console.WriteLine("Возведение в степень числа");
Console.Write("Введите число, которое необходимо возвести в степень: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральную степень, в которую необходимо возвести число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int count = 1;
double numC = 1;
double Exponentiation(double num1, int num2, int i, double num3)
{
    i = 1;
    num3 = 1;
    while (i <= num2)
    {
        num3 = num3 * num1;
        i++;
    }
    return Math.Round(num3, 2);
}
if (numB < 0)
{
    Console.WriteLine($"Вы ввели отрицательное число, данный алгоритм предназначен для нахождения только натуральной степени, возможно, Вы имели ввиду {-numB}");
    numB = -numB;
}
double result = Exponentiation(numA, numB, count, numC);
Console.WriteLine($"{numA} в степени {numB} равен: {result}");
