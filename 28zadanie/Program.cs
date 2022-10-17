// Take the number and write multiplication of numbers from 1 to N
Console.Clear();
Console.WriteLine("Type integer number:");
int num = Convert.ToInt32(Console.ReadLine());
int Mult (int num1)
{
    int multi = 1;
    for (int i = 1; i <= num1; i++)
    {

multi = multi*i;
    }
    return multi;
}
int multik = Mult(num);
Console.WriteLine($"Multiplication of numbers from 1 to {num} is {multik}");