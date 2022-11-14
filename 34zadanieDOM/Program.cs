// задайте массив, рандмно заполненный положительными трехзначными числами. Показать количество четных элементов в массиве

Console.Clear();
int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i< size; i ++)
    {
        array[i]= rnd.Next(min, max+1);
    }
return array; 
}
void PrintArray (int[] array)
{
Console.Write("[");
for (int i = 0; i< array.Length; i++)
{
    if (i< array.Length-1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
}
Console.Write("]");
}
int CountEvenNumbers (int[] array)
{
    int count = default;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i]%2==0) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(6, 100, 999);
PrintArray(arr);
int result = CountEvenNumbers(arr);
Console.WriteLine();
Console.Write($"There is {result} even numbers");
