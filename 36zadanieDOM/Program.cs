// Одномерный массив, заполненный случайными числами. Найти сумму элементов, стоящих на нечетных позициях

Console.Clear();
int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array= new int[size];
    Random rnd = new Random();
    for (int i = 0; i< size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i <array.Length; i++)
    {
    if (i< array.Length-1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int Count (int[] array)
{
    int count = default;
    for (int i = 0; i<array.Length; i ++)
    {
        if (i%2==1) count= count+ array[i];
    }
    return count;
}
int[] arr = CreateArrayRndInt (6, 0, 10);
PrintArray(arr);
int result= Count(arr);
Console.Write($"The summary of odd numbers is {result}");