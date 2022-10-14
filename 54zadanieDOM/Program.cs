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

void SortDescOrderArrayRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(1) - 1; l++)
            {
                if (matrix[i, l] < matrix[i, l + 1])
                {
                    int temp = matrix[i, l + 1];
                    matrix[i, l + 1] = matrix[i, l];
                    matrix[i, l] = temp;
                }
            }
        }
    }
}
Console.Clear();
Random rand = new Random();
int randRows = rand.Next(5, 5),
    randColumns = rand.Next(5, 5);
Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine("Исходный массив");
Console.WriteLine("*******************************");
int[,] array2D = CreateMatrixRndInt(randRows, randColumns, 1, 99);
PrintMatrix(array2D);
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine();
Console.WriteLine("Отсортированный массив");
Console.WriteLine("*******************************");
SortDescOrderArrayRows(array2D);
PrintMatrix(array2D);
Console.WriteLine();