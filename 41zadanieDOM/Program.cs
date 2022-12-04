// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Подсчет элементов массива, больших 0");
Console.WriteLine("************************************");
int[] CreateArrayManualInt(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int CountPosNumbersArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+= 1;
    }
    return count;
}
Console.Write("Введите размер массива: ");
int arrsize = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayManualInt(arrsize);
Console.WriteLine("************************************");
Console.WriteLine("Получен массив:");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("************************************");
Console.WriteLine($"Количество чисел, больших 0: {CountPosNumbersArray(arr)}");