// Take a number and write the number of digits in it
Console.Clear();
Console.Write("Type the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Count(int num)
{
int i;
if (num/10==0)
{
    i=1;
}
else
{
    for (i=1; i<=num; i++)
{
num= num/10;
}
}
return i;
}

int digits = Count(number);
Console.WriteLine($"Number {number} contains {digits} digits");