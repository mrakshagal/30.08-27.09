// Принимает на вход два числа и возводит первое число в натуральную степень второго числа

Console.Clear();
Console.Write("Type the number which is gonna be raised to a power: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Type the integer number which is gonna be the power:");
int b = Convert.ToInt32(Console.ReadLine());
if (b<=0)
{
    Console.Write("B must be integer number!!!");
}
else
{
    int Pow(int a1, int b1)
    {
        int i;
        int power = a1;
        for (i=2; i<= b1; i++)
        {
            power= power*a1;
        }
        return power;
    }
   int p= Pow (a,b);
Console.WriteLine($"{p}");
}
