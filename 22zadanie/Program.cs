// Напишите программу, которая принимает на вход натуральное число и показывает квадраты чисел на расстоянии от 1 до этого числа 

Console.Clear();
Console.Write("Type integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
void squares (int num1, int count1)
{
    while(count1 <= num1)
    {
        Console.WriteLine($"{count1}-> {count1*count1}, ");
        count1++;
    }
}
squares(num, count);