// Написать программу, замены элементов массива- положительные менять на отрицательные и наоборот 

Console.Clear();
Console.WriteLine();
int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for ( int i = 0; i< size; i++)
    {
        array[i]= rnd.Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for( int i= 0; i< array.Length; i++)
    {
        if (i<array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] Inverse(int[] array)
{
    for(int i= 0; i< array.Length; i++)
    {
        array[i]= array[i]*-1;
    }
    return array;
}
int[] arr= CreateArrayRndInt(4,-10, 10);
PrintArray(arr);
Console.WriteLine();
int[] result = Inverse(arr);
PrintArray(result);
Console.WriteLine();

