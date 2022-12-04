// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Finding the common point for two lines: y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("");
Console.Write("Type b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Type k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Tpe b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Type k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
void PrintArray (double[] array)
{
    Console.Write("(");
    for (int i =0; i<array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write(")");
}
double[] CalcIntersectionPoint(double bb1, double kk1, double bb2, double kk2)
{
double x = Math.Round((bb2-bb1)/(kk1-kk2),2);
double y = Math.Round(kk1*(bb2-bb1)/(kk1-kk2)+bb1,2);
double[] array = new double[2];
array[0]=x;
array[1]=y;
return array;
}
double[] arr = CalcIntersectionPoint(b1, k1, b2, k2);
Console.WriteLine("");
Console.Write($"Intersection point is: ");
PrintArray(arr);
Console.WriteLine("");