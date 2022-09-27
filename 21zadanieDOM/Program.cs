Console.Clear();
Console.WriteLine("Нахождение расстояние между двумя точками в трехмерном пространстве");
Console.WriteLine("Введите координаты точки A: ");
Console.Write("x:");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("y:");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("z:");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x:");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("y:");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("z:");
double bz = Convert.ToDouble(Console.ReadLine());

double Result(double ax1, double ay1, double az1, double bx1, double by1, double bz1)
{
    return Math.Sqrt((ax1 - bx1) * (ax1 - bx1) + (ay1 - by1) * (ay1 - by1) + (az1 - bz1) * (az1 - bz1));
}
double result = Result(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками составит: {Math.Round(result, 2, MidpointRounding.ToZero)}");