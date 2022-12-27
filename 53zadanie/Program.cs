//massiv 2d/ pomeniajet pierwuju i posledniuju stroku massiva 

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
int[,] SwitchFirstAndLastMatrixVerse(int[,] matrix)
{
    int temp = default;
    int LinesCount = matrix.GetLength(0);
    int ColumnsCount = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[LinesCount - 1, j];
                matrix[LinesCount-1,j]= temp;
            }
        }
    }
    return matrix;
}
int[,] array2d = CreateMatrixRndInt(3,4,1,9);
PrintMartix(array2d);
SwitchFirstAndLastMatrixVerse(array2d);
Console.WriteLine("                    |");
Console.WriteLine("                    |");
Console.WriteLine("                    |");
Console.WriteLine("                    |");
PrintMartix(array2d);