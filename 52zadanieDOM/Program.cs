//Int massiv. Naiti srednee arifm w kazhdom stolbce 
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
void ArithmeticMeanColumnsArrayToConsole(int[,] matrix)
{
    double arithmeticMean = default;
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arithmeticMean = sum / matrix.GetLength(0);
        Console.Write($" {Math.Round(arithmeticMean, 1),2}");
    }
}
int[,] array2d = CreateMatrixRndInt(5,5,1,10);
PrintMartix(array2d);
ArithmeticMeanColumnsArrayToConsole(array2d);