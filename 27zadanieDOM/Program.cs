// The summary of digits of the number

Console.Clear();
Console.WriteLine("Type the number:");
int a = Convert.ToInt32(Console.ReadLine());
int accum = 0;
int count = 0;
if (a < 0) a=-a;
int countsummaryofdigits (int num1, int accum1, int i)
{
    while (num1 !=0)
    {
        accum1= accum1+ num1%10;
        num1= num1/10;
        i++;
    }
    return accum1;
}
int result = countsummaryofdigits ( a,  accum,  count);
Console.WriteLine($"The summary of digits in number {a} is {result}");
