Console.Clear();
Console.WriteLine("Создание двумерного массива и заполнение случайными вещественными числами");
Console.WriteLine("*************************************************************************");
Console.Write("Введите количество строк: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n =Convert.ToInt32(Console.ReadLine());


double [,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double [,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble()+rnd.Next(min, max),1);
        }

    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }
}

double[,] array2D = CreateMatrixRndDouble(m, n, -10, 10);
Console.WriteLine("*************************************************************************");
PrintMatrix(array2D);