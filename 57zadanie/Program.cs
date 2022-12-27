//chastotnyi slowar elementow massiva. 

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}
void PrintMartix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}
int[] CreateArrayFromMatrix(int[,] matrix)
{
    int count = 0;
    int[] newArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[count] = matrix[i, j];
            count++;
        }
    }
    return newArray;
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
void ShowCount(int[] array)
{
    int num = array[0];
    int count = 1;
    Console.WriteLine();
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} repeats {count} times.");
            num = array[i];
            count = 1;

        }
        if(i == array.Length-1)Console.WriteLine($"{num} repeats {count} times.");
    }
}
int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMartix(array2d);
Console.WriteLine();
int[] array = CreateArrayFromMatrix(array2d);
Array.Sort(array);
PrintArray(array);
ShowCount(array);
