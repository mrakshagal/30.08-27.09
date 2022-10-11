﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
        Console.Write($" {Math.Round(arithmeticMean, 1),2}|");
    }
}

Console.Clear();
Random rand = new Random();
int randRows = rand.Next(7, 15),
    randColumns = rand.Next(7, 15);
Console.WriteLine("Поиск среднего арифметического элементов в каждом столбце.");
Console.WriteLine("*******************************************************");
int[,] array2D = CreateMatrixRndInt(randRows, randColumns, 5, 9);
PrintMatrix(array2D);
Console.WriteLine("*******среднее арифметическое элементов****************");
ArithmeticMeanColumnsArrayToConsole(array2D);
Console.WriteLine();