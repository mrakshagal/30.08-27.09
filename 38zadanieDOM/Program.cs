// Задать элемент вещественных чисел. Найти разницу между максимальным и минимальным элементом массива

Console.Clear();
double[] CreateArrayRndDouble (int size)
{
    double[] array = new double[size];
    Random rnd = new Random ();
    for (int i = 0; i<size; i++)
    {
        array[i]= rnd.NextDouble()+ rnd.Next(-10,10);
    }
    return array;
}
void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i< array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
double FindMax (double[] array)
{
    double max= array[0];
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]>=max) max= array[i];
    }
    return max;
}
double FindMin (double[] array)
{
    double min = array[0];
for(int i =0; i<array.Length; i++)
{
    if (array[i]<=min) min= array[i];
}
return min;
}
double[] arr = CreateArrayRndDouble(7);
PrintArray(arr);
FindMax(arr);
FindMin(arr);
double result = FindMax(arr)- FindMin(arr);
Console.WriteLine("------------------------------------");
Console.WriteLine($"{FindMax(arr)} and {FindMin(arr)}");
Console.WriteLine($"The answer is {result}");


