﻿Console.Clear();
Console.WriteLine();
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i< array.Length; i++)
    {
        if(i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
bool ArraySearch(int[] array, int search1)
{
    bool exist = false;
    for (int i= 0; i< array.Length; i++)
    {
        if (array[i]== search1) 
        {exist = true;
        break;
        }
    }
    return exist;
}
int[] arr = CreateArrayRndInt(5, -10, 10);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Type the number you want to find: ");
int search = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool result= ArraySearch(arr, search);
Console.WriteLine($"{result}");