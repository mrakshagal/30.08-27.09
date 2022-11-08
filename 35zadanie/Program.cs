//Одномерный массив из 123 чисел. Количество элементов массива, значение которых находится в диапазоне от 10 до 99
Console.Clear();
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i< size; i ++)
    {
        array[i]= rnd.Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write($"]");
}
int search(int[] array)
{
    int count =0;
    for(int i =0; i< array.Length; i++)
    {
        if (array[i] >= 10 & array[i]<= 99) count++;
    }
    return count;
}
int[] arr= CreateArrayRndInt(5,0,999);
PrintArray(arr);
int result = search(arr);
Console.WriteLine();
Console.Write($"There are/is {result} numbers between 10 and 99 ");