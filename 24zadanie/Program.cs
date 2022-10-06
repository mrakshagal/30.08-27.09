// Принимает на вход число и выдает сумму чисел от 1 до этого числа 

Console.Clear();
Console.Write("Type integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int Summary (int num1)
{
    int sum = default;
    for (int i = 1; i <= num1; i++)
    {
// sum= sum+i
sum += i;
    }
    return sum;
}
int summar = Summary(num);
Console.WriteLine($"Summary of numbers from 1 to {num} is {summar}");