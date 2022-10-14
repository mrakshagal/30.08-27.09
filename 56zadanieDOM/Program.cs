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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],3}| ");
            else
                Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
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

Console.Clear();
Random rand = new Random();
int Rows = 9,
    Columns = 3;
Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine("Нахождение строки с наименьшей суммой элементов");
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("***********************************************");
Console.ForegroundColor=ConsoleColor.Red;
int[,] array2D = CreateMatrixRndInt(Rows, Columns, 1, 5);
PrintMatrix(array2D);
NumRowMinSumElements(array2D);
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("***********************************************");
Console.ForegroundColor=ConsoleColor.Blue;
Console.Write("Номер строки с наименьшей суммой элементов: ");
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine($"{NumRowMinSumElements(array2D)}");
Console.WriteLine();