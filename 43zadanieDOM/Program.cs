Console.Clear();
Console.WriteLine("Нахождение точки пересечения прямых, заданных систему уравнений y = k1 * x + b1, y = k2 * x + b2: ");
Console.WriteLine("*************************************************************************************************");
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}; ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write(")");
}
double[] CalcIntersectionPoint(double b11, double k11, double b22, double k22)
{
    double x = Math.Round((b22 - b11) / (k11 - k22), 2);
    double y = Math.Round(k11 * (b22 - b11) / (k11 - k22) + b11, 2);
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}
double[] arr = CalcIntersectionPoint(b1, k1, b2, k2);
Console.WriteLine("*************************************");
Console.Write("Точка пересечения: ");
PrintArray(arr);
Console.WriteLine();