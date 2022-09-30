Console.Clear();
int[] arr1 = new int[8];
void FillArray(int[] array)
{
    int count = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 999999999);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == 0) Console.Write("[");
        if (i == count - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}
FillArray(arr1);
PrintArray(arr1);
Console.WriteLine();