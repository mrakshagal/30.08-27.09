// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Clear();
Console.Write("Type the number of the day of the week: ");
string day = Console.ReadLine();
if (day == "1")
{
    Console.WriteLine("Monday");
}
else if (day == "2")
{
    Console.WriteLine("Tuesday");
}
else if (day == "3")
{
    Console.WriteLine("Wednesday");
}
else if (day == "4")
{
    Console.WriteLine("Thursday");
}
else if (day == "5")
{
    Console.WriteLine("Friday");
}
else if (day == "6")
{
    Console.WriteLine("Saturday");
}
else if (day == "7")
{
    Console.WriteLine("Sunday");
}
else
{
    Console.Write("Theres no such day");
}
