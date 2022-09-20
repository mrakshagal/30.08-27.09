// Напишите программу, которая на вход
// 1.принимает число и 2.выдаёт его квадрат (число
// умноженное на само себя).
// 3.wynik
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Clear();
Console.Write( "Type integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Square of number {num} = {square}");


