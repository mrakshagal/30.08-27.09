// kopia massiva poelementnoe kopirowanie
Console.Clear();
int [] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd =new Random();
    for (int i =0; i< size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i =0; i < array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i =0; i<array.Length; i++)
    {
        array2[i]= array[i];
    }
    return array2;
}
int[] arr= CreateArrayRndInt(9,1,10);
PrintArray(arr);
Console.WriteLine();
CopyArray(arr);
PrintArray(arr);