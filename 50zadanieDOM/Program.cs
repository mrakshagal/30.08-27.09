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

void SearchArrayElement(int[,] matrix, int k, int l)
{
    if (k > matrix.GetLength(0) || l > matrix.GetLength(1) || k <= 0 || l <= 0)
        Console.WriteLine("такого числа в массиве нет");
    else
        Console.WriteLine($"Искомое значение: {matrix.GetValue(k - 1, l - 1)}");
}

Console.Clear();
Random rand = new Random();
int randRows = rand.Next(3, 7),
    randColumns = rand.Next(3, 7);
Console.WriteLine("Поиск значения двумерного массива по позициям элемента.");
Console.WriteLine("*******************************************************");
int[,] array2D = CreateMatrixRndInt(randRows, randColumns, -10, 10);
PrintMatrix(array2D);
Console.WriteLine("*******************************************************");
Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
SearchArrayElement(array2D, i, j);