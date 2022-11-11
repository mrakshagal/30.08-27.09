//Посчитать произведение пар в одномерном массиве. Парой считается первая и последняя цифра, второй и предпоследний и вывести полученный новый массив. 

Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] ProductPairOfDigits (int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size += 1;
    int[] newArray = new int[size];
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[array.Length - 1 -i];
        }
        if (newArray.Length % 2 != 0) newArray[newArray.Length - 1] = array[array.Length / 2];
        return newArray;
}
Console.WriteLine();
int[] arr = CreateArrayRndInt (8,1,5);
PrintArray(arr);
int[] result = ProductPairOfDigits(arr);
Console.WriteLine();
PrintArray(result);
Console.WriteLine();