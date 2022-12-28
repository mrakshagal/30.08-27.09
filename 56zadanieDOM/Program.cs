// array2d. stroka s naimenshej summoi elementow

Console.Clear();
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
int NumRowMinSumElements(int[,] matrix)
{
    int minRow = default,
        minSumRow = default,
        sumRow = default;
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        minRow += matrix[0, k];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = default;
    }
    return minSumRow + 1;
}
int[,] array2d = CreateMatrixRndInt(5,5, 1, 9);
PrintMartix(array2d);
Console.WriteLine();
Console.WriteLine();
NumRowMinSumElements(array2d);
Console.WriteLine($"{NumRowMinSumElements(array2d)}");