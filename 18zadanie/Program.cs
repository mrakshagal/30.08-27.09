// Программа, которая по заданному номеру четверти показывает диапазон возможных координат точек этой четверти

Console.Clear();
Console.Write("Provide the number of the quater: ");
int q = Convert.ToInt32(Console.ReadLine());
string quater(int qq)
{
    if (qq == 1) return "x > 0, y > 0 ";
    if (qq == 2) return "x < 0, y > 0";
    if (qq == 3) return "x<0, y <0";
    if (qq == 4) return "x>0, y <0";
    return "there is no such quater";
}
string result = quater(q);
Console.WriteLine(result);
