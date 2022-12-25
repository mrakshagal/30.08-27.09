//Massiv, Oba indeksa chetnye i vozvesti w kwadrat

Console.Clear();
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}
void SquareEvenElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
}
int [,] array2d = CreateMatrixRndInt(3,4,1,9);
PrintMartix(array2d);
SquareEvenElements(array2d);
Console.WriteLine("               |");
Console.WriteLine("               |");
Console.WriteLine("               |");
PrintMartix(array2d);
