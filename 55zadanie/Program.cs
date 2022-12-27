//massiv 2d. stroki na stolbcy. w sluchae esli niewozmozhno, to programma dolzhna wywesti soobshenie 
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
int[,] SwitchLinesAndColumns(int[,] matrix)
{
    int temp = default;
    int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
if (matrix.GetLength(0)== matrix.GetLength(1))
{
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i+1; j < matrix.GetLength(1); j++)
            {
                temp = matrix[i,j];
                matrix[i,j]= matrix[j,i];
                newmatrix[i,j]= matrix [j,i];   
            }
        }
}
    else Console.WriteLine("Impossible!");
    return newmatrix;
}
int[,] array2d =CreateMatrixRndInt(3,3,1,9);
PrintMartix(array2d);
SwitchLinesAndColumns(array2d);
Console.WriteLine();
Console.WriteLine();
PrintMartix(array2d);