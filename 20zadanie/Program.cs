// Принимает на вход две точки и находит расстояние между ними в 2д пространстве 
Console.Clear();
Console.WriteLine("Zadadim koordinaty pierwoj tochki!");
Console.Write("Wwedi koordinatu X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Wwedi koordinatu Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zadadim koordinaty wtoroj tochki!");
Console.Write("Wwedi koordinatu X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Wwedi koordinatu Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
double distance(int xc1, int yc1, int xc2, int yc2)
{
    double dis1 = Math.Pow(xc2 - xc1, 2);
    double dis2 = Math.Pow(yc2 - yc1, 2);
    double dis3 = Math.Sqrt(dis1 + dis2);
    return dis3;
}
double result = distance( x1, y1, x2, y2);
Console.Write($"Distance between two points is {result}");

