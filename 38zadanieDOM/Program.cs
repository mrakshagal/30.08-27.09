Console.Clear();
Console.WriteLine("Разница между минимальным и максимальным элементом массива");
Console.WriteLine("----------------------------------------------------------");

double[] CreateArrayRndDouble(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() + rnd.Next(-100, 100);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 2)} ; ");
        else Console.Write($"{Math.Round(array[i], 2)}");
    }
    Console.Write("]");
}
void DiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max) max = array[i];
        if (array[i] <= min) min = array[i];
    }
    Console.WriteLine($"Max -> {Math.Round(max, 2)} ");
    Console.WriteLine($"Min -> {Math.Round(min, 2)}");
    Console.WriteLine($"Разница -> {Math.Round(max - min, 2)}");
}
double[] arr = CreateArrayRndDouble(12);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("----------------------------------------------------------");
DiffMinMax(arr);