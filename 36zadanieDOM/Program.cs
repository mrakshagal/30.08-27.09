Console.Clear();
Console.WriteLine("Нахождение суммы элементов, стоящих на нечетных позициях");
Console.WriteLine("--------------------------------------------------------");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int SumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
int[] arr = CreateArrayRndInt(10, -10, 10);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях: {SumOddPositions(arr)}");
Console.WriteLine();