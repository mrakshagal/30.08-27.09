// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


Console.Clear();
Console.Write("Type X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Type Y: ");
int y = Convert.ToInt32(Console.ReadLine());
string quater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "first quater";
    if (xc < 0 && yc > 0) return "second quater";
    if (xc < 0 && yc < 0) return "third quater";
    if (xc > 0 && yc < 0) return "forth quater"; 
    return "Incorrect";
}
String result =  quater(x, y);
Console.WriteLine(result);
