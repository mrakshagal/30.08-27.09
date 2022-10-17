Console.Clear();
int[] arr = {5,5,5,5,5,5,5,5};
void PrintArray(int[] array)
{
    int count= array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i]= new Random().Next(0,2);
        Console.Write($"{array[i]}");
    }
Console.WriteLine();
}
PrintArray(arr);